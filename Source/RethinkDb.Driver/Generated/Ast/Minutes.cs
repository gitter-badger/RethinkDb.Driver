












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

    public partial class Minutes : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return the minute in a time object as a number between 0 and 59.</para>
/// </summary>
/// <example><para>Example: Return all the posts submitted during the first 10 minutes of every hour.</para>
/// <code>r.table("posts").filter(function(post) {
///     return post("date").minutes().lt(10)
/// })
/// </code></example>
        public Minutes (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return the minute in a time object as a number between 0 and 59.</para>
/// </summary>
/// <example><para>Example: Return all the posts submitted during the first 10 minutes of every hour.</para>
/// <code>r.table("posts").filter(function(post) {
///     return post("date").minutes().lt(10)
/// })
/// </code></example>
        public Minutes (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return the minute in a time object as a number between 0 and 59.</para>
/// </summary>
/// <example><para>Example: Return all the posts submitted during the first 10 minutes of every hour.</para>
/// <code>r.table("posts").filter(function(post) {
///     return post("date").minutes().lt(10)
/// })
/// </code></example>
        public Minutes (Arguments args, OptArgs optargs)
         : base(TermType.MINUTES, args, optargs) {
        }


    



    


    

    


    
    }
}
