












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

    public partial class Count : ReqlExpr {

    
    
    
/// <summary>
/// <para>Count the number of elements in the sequence. With a single argument, count the number
/// of elements equal to it. If the argument is a function, it is equivalent to calling
/// filter before count.</para>
/// </summary>
/// <example><para>Example: Just how many super heroes are there?</para>
/// <code>r.table('marvel').count().add(r.table('dc').count()).run(conn, callback)
/// </code></example>
        public Count (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Count the number of elements in the sequence. With a single argument, count the number
/// of elements equal to it. If the argument is a function, it is equivalent to calling
/// filter before count.</para>
/// </summary>
/// <example><para>Example: Just how many super heroes are there?</para>
/// <code>r.table('marvel').count().add(r.table('dc').count()).run(conn, callback)
/// </code></example>
        public Count (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Count the number of elements in the sequence. With a single argument, count the number
/// of elements equal to it. If the argument is a function, it is equivalent to calling
/// filter before count.</para>
/// </summary>
/// <example><para>Example: Just how many super heroes are there?</para>
/// <code>r.table('marvel').count().add(r.table('dc').count()).run(conn, callback)
/// </code></example>
        public Count (Arguments args, OptArgs optargs)
         : base(TermType.COUNT, args, optargs) {
        }


    



    


    

    


    
    }
}
