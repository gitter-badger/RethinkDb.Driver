












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

    public partial class Ne : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if two values are not equal.</para>
/// </summary>
/// <example><para>Example: Does 2 not equal 2?</para>
/// <code>r.expr(2).ne(2).run(conn, callback)
/// </code></example>
        public Ne (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if two values are not equal.</para>
/// </summary>
/// <example><para>Example: Does 2 not equal 2?</para>
/// <code>r.expr(2).ne(2).run(conn, callback)
/// </code></example>
        public Ne (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if two values are not equal.</para>
/// </summary>
/// <example><para>Example: Does 2 not equal 2?</para>
/// <code>r.expr(2).ne(2).run(conn, callback)
/// </code></example>
        public Ne (Arguments args, OptArgs optargs)
         : base(TermType.NE, args, optargs) {
        }


    



    


    

    


    
    }
}
