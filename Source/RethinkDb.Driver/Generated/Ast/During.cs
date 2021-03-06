












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class During : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return if a time is between two other times (by default, inclusive for the start, exclusive for the end).</para>
/// </summary>
/// <example><para>Example: Retrieve all the posts that were posted between December 1st, 2013 (inclusive) and December 10th, 2013 (exclusive).</para>
/// <code>r.table("posts").filter(
///     r.row('date').during(r.time(2013, 12, 1), r.time(2013, 12, 10))
/// ).run(conn, callback)
/// </code></example>
        public During (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return if a time is between two other times (by default, inclusive for the start, exclusive for the end).</para>
/// </summary>
/// <example><para>Example: Retrieve all the posts that were posted between December 1st, 2013 (inclusive) and December 10th, 2013 (exclusive).</para>
/// <code>r.table("posts").filter(
///     r.row('date').during(r.time(2013, 12, 1), r.time(2013, 12, 10))
/// ).run(conn, callback)
/// </code></example>
        public During (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return if a time is between two other times (by default, inclusive for the start, exclusive for the end).</para>
/// </summary>
/// <example><para>Example: Retrieve all the posts that were posted between December 1st, 2013 (inclusive) and December 10th, 2013 (exclusive).</para>
/// <code>r.table("posts").filter(
///     r.row('date').during(r.time(2013, 12, 1), r.time(2013, 12, 10))
/// ).run(conn, callback)
/// </code></example>
        public During (Arguments args, OptArgs optargs)
         : base(TermType.DURING, args, optargs) {
        }


    



    
///<summary>
/// "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public During this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new During (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public During optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new During (this.Args, newOptargs);
        }


    

    


    
    }
}
