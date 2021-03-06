using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NodaTime;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Net;
using Z.ExtensionMethods;

namespace RethinkDb.Driver.Tests
{
    public static class TestingCommon
    {
        // Python test conversion compatibility definitions

        public static void assertEquals(double expected, double obtained, double delta)
        {
            obtained.Should().BeInRange(expected - delta, expected + delta);
        }

        public static void assertArrayEquals(IEnumerable expected, IEnumerable obtained)
        {
            var ej = JsonConvert.SerializeObject(expected);
            var oj = JsonConvert.SerializeObject(expected);
            oj.Should().Be(ej);
        }

        public static void assertEquals(object expected, object obtained)
        {
            var err = expected as Err;
            if( err != null )
            {
                err.Equals(obtained).Should().BeTrue();
                return;
            }
            var errregex = expected as ErrRegex;
            if( errregex != null )
            {
                errregex.Equals(obtained).Should().BeTrue("ErrRegex Match Failed.");
                return;
            }

            var intCmp = expected as IntCmp;
            if( intCmp != null )
            {
                intCmp.Equals(obtained)
                    .Should().BeTrue();

                return;
            }

            var floatCmp = expected as FloatCmp;
            if( floatCmp != null )
            {
                floatCmp.Equals(obtained)
                    .Should().BeTrue();

                return;
            }

            var bag = expected as Bag;
            if( bag != null )
            {
                bag.Equals(obtained)
                    .Should().BeTrue();
                return;
            }

            if (expected is PartialDct)
            {
                var obtainedDct = obtained as JObject;

                ((PartialDct)expected).Equals(obtainedDct.ToSortedDictionary())
                    .Should().BeTrue();

                return;
            }

            var uuid = expected as Uuid;
            if( expected is Uuid )
            {
                uuid.Equals(obtained)
                    .Should().BeTrue();

                return;
            }

            var map = expected as MapObject;
            if( map != null )
            {
                var oobj = obtained as JObject;
                foreach( var kvp in map )
                {
                    var valExpected = map[kvp.Key];
                    var valObtained = oobj[kvp.Key];

                    if( valExpected == null && valObtained.Type == JTokenType.Null )
                        continue;
                    if(JToken.DeepEquals(JToken.FromObject(valExpected), valObtained))
                        continue;
                    if( valExpected.Equals(valObtained) )
                        continue;

                    //else keep checking
                    //CheckEquals(valExpected, valObtained);
                    assertEquals(valExpected, valObtained);

                }

                return;
            }

            if( expected is string && obtained is DateTime )
            {
                var expectedTime = DateTimeOffset.Parse(expected as string).ToUniversalTime().DateTime;
                ((DateTime)obtained).ToUniversalTime()
                    .Should().Be(expectedTime);

                return;
            }

            if( expected is IList )
            {
                var el = expected as IList;
                var ol = obtained as IList;

                for( int i = 0; i < el.Count; i++ )
                {
                    assertEquals(el[i], ol[i]);
                }

                return;
            }

            if( expected is AnythingIsFineBro )
            {
                return;
            }

            
            CheckEquals(expected, obtained);


            /*Console.WriteLine(">>>>>>>>>>>>>>>>>>> ASSERT FAIL");

            if( obtained is Exception )
                Console.WriteLine(((Exception)obtained).Message);
            Assert.Fail($"Couldn't compare expected: {expected.GetType().Name} and obtained: {obtained.GetType().Name}");*/
        }

        public static void CheckEquals(object expected, object obtained)
        {
            if( obtained is JObject )
            {
                var jobj = obtained as JObject;
                JToken reql_type;
                if( jobj.TryGetValue("$reql_type$", out reql_type ) )
                {
                    if( reql_type.Value<string>() == Converter.Time )
                    {
                        obtained = jobj.ToObject<DateTimeOffset>(Converter.Serializer);
                    }
                }
            }

            var ej = JsonConvert.SerializeObject(expected);
            var oj = JsonConvert.SerializeObject(obtained);

            oj.Should().Be(ej);
        }

        public static dynamic maybeRun(object query, Connection conn)
        {
            if( query is ReqlAst )
            {
                return ((ReqlAst)query).run(conn);
            }
            else
            {
                return query;
            }
        }

        public static dynamic runOrCatch(object query, object runopts, Connection conn)
        {
            if( query == null )
                return null;

            if( query is IList )
                return query;

            try
            {
                var res = ((ReqlAst)query).run(conn, runopts);

                if( res is ICursor )
                {
                    var cur = (ICursor)res;
                    var list = new JArray();
                    foreach( var obj in cur )
                    {
                        list.Add(obj);
                    }
                    return list;
                }
                return res;
            }
            catch( Exception e )
            {
                //throw e;
                return e;
            }
        }

        public class Err
        {
            private string errorMessage;
            private string errorType;
            private object obj;
            private Type clazz;

            private Regex inRegex = new Regex("^(?<message>[^\n]*?)(?: in)?:\n.*$", RegexOptions.Singleline);
            private Regex assertionRegex = new Regex("^(?<message>[^\n]*?)\nFailed assertion:.*$", RegexOptions.Singleline);

            public Err(string errorType, string errorMessage, object obj)
            {
                this.errorType = errorType;
                this.errorMessage = errorMessage;
                this.obj = obj;

                //check if the errortype exists.
                this.clazz = Type.GetType($"RethinkDb.Driver.{errorType}, RethinkDb.Driver", throwOnError: true);
            }

            public override bool Equals(object obj)
            {
                if( obj.GetType() != this.clazz )
                {
                    obj.GetType().Should().Be(this.clazz);
                    return false;
                }

                var otherMessage = ((Exception)obj).Message;

                var isValid = this.errorMessage.Equals(otherMessage);
                if ( isValid )
                {
                    return true;
                }//else keep matching

                var inMatch = inRegex.Match(otherMessage);
                if( inMatch.Success )
                {
                    otherMessage = inMatch.Result("${message}:");
                }
                var assertionMatch = assertionRegex.Match(otherMessage);
                if( assertionMatch.Success )
                {
                    otherMessage = assertionMatch.Result("${message}");
                }

                Clean(this.errorMessage).Should().Be(Clean(otherMessage));
                return true;
            }

            private string Clean(string str)
            {
                return str.Replace("`", "")
                    .Replace("\"", "")
                    .ToLowerInvariant();
            }

            public override string ToString()
            {
                return $"Err({clazz}: {errorMessage})";
            }
        }

        public static Err err(string errorType, string errorMessage)
        {
            return new Err(errorType, errorMessage, null);
        }

        public static Err err(string errorType, string errorMessage, object obj)
        {
            return new Err(errorType, errorMessage, obj);
        }

        public static object wait_(long length)
        {
            Thread.Sleep((int)length * 1000);
            return null;
        }

        public static int len(IList array)
        {
            return array.Count;
        }

        public class Lst
        {
            private IList lst;

            public Lst(IList lst)
            {
                this.lst = lst;
            }

            public override bool Equals(Object other)
            {
                return lst.Equals(other);
            }
        }

        public class Bag
        {
            private IList lst;

            public Bag(IList lst)
            {
                this.lst = lst;
            }

            public override bool Equals(object other)
            {
                if( !(other is IList) )
                {
                    other.GetType().Should().Be(typeof(IList));
                    return false;
                }

               /* if( this.lst.Count > 0 &&
                    this.lst[0] is string &&
                    other is JArray )
                {
                    //get a list of strings?
                    var jarr = other as JArray;
                    var values = jarr.ToObject<string[]>();
                    values.Should().Contain(values);
                    return true;
                }*/
                //else keep matching.

                for( var i = 0; i < this.lst.Count; i++ )
                {
                    var current = this.lst[i];
                    var jrr = other as IList;
                    var anyMatch = false;
                    //do any asserts pass?
                    for( var j = 0; j < jrr.Count; j++ )
                    {
                        var obtained = jrr[j];
                        try
                        {
                            assertEquals(current, obtained);
                            anyMatch = true;
                            break;
                        }
                        catch
                        {
                            
                        }
                    }
                    if( !anyMatch )
                    {
                        //nothing matched in that run. so throw.
                        return false;
                    }
                }

                return true;
                //var otherList = ((IList)other).OfType<object>().ToList();
                //otherList.Sort();
                //return lst.Equals(otherList);
            }

            public override string ToString()
            {
                return $"Bag({lst}))";
            }
        }

        public static Bag bag(IList lst)
        {
            return new Bag(lst);
        }

        public class Partial
        {
        }

        public class PartialLst : Partial
        {
            private IList lst;

            public PartialLst(IList lst)
            {
                this.lst = lst;
            }

            public override bool Equals(Object other)
            {
                if( !(other is IList) )
                {
                    return false;
                }
                var otherList = (IList)other;
                if( lst.Count > otherList.Count )
                {
                    return false;
                }
                foreach( var item in lst )
                {
                    if( otherList.IndexOf(item) == -1 )
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static PartialLst partial(IList lst)
        {
            return new PartialLst(lst);
        }

        public class PartialDct : Partial
        {
            private IDictionary dct;

            public PartialDct(IDictionary dct)
            {
                this.dct = dct;
            }

            public override bool Equals(Object other)
            {
                if( !(other is IDictionary) )
                {
                    return false;
                }
                var otherDict = ((IDictionary)other);

                foreach( var entry in dct.Keys )
                {
                    var key = entry;
                    var val = dct[key];


                    otherDict.Contains(key).Should()
                        .BeTrue($"The key {key} must exist in the obtained.");
                    
                    var otherVal = otherDict[key];

                    if (val is IList)
                    {
                        assertEquals(val, otherVal);
                        continue;
                    }
                    if( val is PartialDct )
                    {
                        assertEquals(val, otherVal);
                        continue;
                    }

                    if ( val == null && otherVal == null )
                        continue;

                    if( val == null && otherVal is JToken && ((JToken)otherVal).Type == JTokenType.Null)
                        continue;

                    if( val == null && otherVal != null ||
                        val != null && otherVal == null )
                    {
                        Console.WriteLine($"One was null and the other wasn't for key {key}");
                        Debugger.Break();
                        return false;
                    }

                    JToken.DeepEquals(JToken.FromObject(val), ((JToken)otherVal))
                        .Should().BeTrue($"Dictionary values of {key} should be equal.");
                }

                return true;
            }
        }

        public static PartialDct partial(MapObject dct)
        {
            return new PartialDct(dct);
        }


        public class ArrLen
        {
            private int length;
            private Object thing;

            public ArrLen(int length, Object thing)
            {
                this.length = length;
                this.thing = thing;
            }

            public override bool Equals(Object other)
            {
                if( !(other is IList) )
                {
                    return false;
                }
                var otherList = (IList)other;
                if( length != otherList.Count )
                {
                    return false;
                }
                if( thing == null )
                {
                    return true;
                }
                foreach( var item in otherList )
                {
                    if( !thing.Equals(item) )
                    {
                        return false;
                    }
                }
                return true;
            }

            public override string ToString()
            {
                return $"ArrLen(length={length} of {thing})";
            }
        }

        public static ArrLen arrlen(double length, object thing)
        {
            return arrlen((int)length, thing);
        }

        public static ArrLen arrlen(int length, Object thing)
        {
            return new ArrLen(length, thing);
        }

        public static ArrLen arrlen(long length)
        {
            return new ArrLen((int)length, null);
        }


        public class Uuid
        {
            public override bool Equals(Object other)
            {
                string str = string.Empty;
                if( other is JValue )
                {
                    str = ((JValue)other).ToObject<string>();
                }
                if( other is string )
                {
                    str = other as string;
                }

                Guid val;
                var success = Guid.TryParse(str, out val);
                success.Should().BeTrue($"The UUID should be able to be parsed by Guid.TryParse(): {str}.");

                return success;
            }

            public override string ToString()
            {
                return $@"Uuid()";
            }
        }

        public static Uuid uuid()
        {
            return new Uuid();
        }


        public class IntCmp
        {
            private long nbr;

            public IntCmp(double nbr)
            {
                this.nbr = (long)nbr;
            }

            public override bool Equals(Object other)
            {
                nbr.Should().Be(Convert.ToInt64(other));
                return true;
            }
        }

        public static IntCmp int_cmp(double nbr)
        {
            return new IntCmp(nbr);
        }

        public class FloatCmp
        {
            private Double nbr;

            public FloatCmp(Double nbr)
            {
                this.nbr = nbr;
            }

            public override bool Equals(Object other)
            {
                nbr.Should().Be(Convert.ToDouble(other));
                return true;
            }
        }

        public static double float_(double nbr)
        {
            return nbr;
        }

        public static FloatCmp float_cmp(Double nbr)
        {
            return new FloatCmp(nbr);
        }


        public class ErrRegex
        {
            public string clazz;
            public String message_rgx;

            public ErrRegex(String classname, String message_rgx)
            {
                this.clazz = classname;
                this.message_rgx = message_rgx;
            }

            public override bool Equals(Object other)
            {
                var otherClass = other.GetType().Name;

                if( !otherClass.EndsWith(this.clazz) )
                {
                    otherClass.Should().EndWith(this.clazz);
                    return false;
                }

                var otherMessage = ((Exception)other).Message;

                return Regex.Match(otherMessage, this.message_rgx).Success;
            }
        }

        public static ErrRegex err_regex(String classname, String message_rgx, object extra)
        {
            return new ErrRegex(classname, message_rgx);
        }

        public static IList fetch(object cursor)
        {
            return fetch(cursor, -1);
        }

        public static IList fetch(object cursor_, long limit)
        {
            if( limit < 0 )
            {
                limit = long.MaxValue;
            }
            var cursor = cursor_ as ICursor;
            long total = 0;
            var result = new ArrayList((int)limit);
            for( long i = 0; i < limit; i++ )
            {
                if( !cursor.MoveNext() )
                {
                    break;
                }
                result.Add(cursor.Current);
            }
            return result;
        }


        public static IEnumerable<int> range(int start, int stop)
        {
            return Enumerable.Range(start, stop);
        }

        public static IEnumerable<int> range(double start, double stop)
        {
            return range((int)start, (int)stop);
        }

        public static ArrayList list(object str)
        {
            return null;
        }

        public static IEnumerable<long> EnumerableLRange(long start, long end)
        {
            for( var i = start; i < end; i++ )
            {
                yield return i;
            }
        }

        public static TimeSpan PacificTimeZone()
        {
            return TimeSpan.FromHours(-7);
        }

        public static TimeSpan UTCTimeZone()
        {
            return TimeSpan.FromHours(0);
        }


        public static class datetime
        {
            public static DateTimeOffset now()
            {
                return DateTimeOffset.Now;
            }

            public static DateTimeOffset fromtimestamp(double seconds, TimeSpan offset)
            {
                var dt = Instant.FromMillisecondsSinceUnixEpoch((long)(seconds * 1000));
                return dt.ToDateTimeOffset().ToOffset(offset);
            }
        }

        public static class ast
        {
            public static TimeSpan rqlTzinfo(string offset)
            {
                return TimeSpan.Parse(offset);
            }
        }

        public class Arrays
        {
            public static IList asList(params object[] p)
            {
                return p.ToList();
            }
        }

        public class AnythingIsFineBro
        {
            public override bool Equals(object obj)
            {
                return true;
            }

            public override string ToString()
            {
                return "AnythingIsFine";
            }
        }

        public static AnythingIsFineBro AnythingIsFine = new AnythingIsFineBro();

        public static class sys
        {
            public static class floatInfo
            {
                public static double max = double.MaxValue;
                public static double min = double.Epsilon; // not double.MinValue
            }
        }
    }

    // Java test compatibility definitions

    public static class ExtensionsForJava
    {
        public static object get(this IList lst, int idx)
        {
            return lst[idx];
        }

        public static byte[] getBytes(this string str, Encoding enc)
        {
            return enc.GetBytes(str);
        }
    }

    public static class StandardCharsets
    {
        public static Encoding US_ASCII
        {
            get { return Encoding.ASCII; }
        }

        public static Encoding UTF_8
        {
            get { return Encoding.UTF8; }
        }

        public static Encoding UTF_16
        {
            get { return Encoding.Unicode; }
        }
    }
}