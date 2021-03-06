












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

    public partial class SpliceAt : ReqlExpr {

    
    
    
/// <summary>
/// <para>Insert several values in to an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Hulk and Thor decide to join the avengers.</para>
/// <code>r.expr(["Iron Man", "Spider-Man"]).spliceAt(1, ["Hulk", "Thor"]).run(conn, callback)
/// </code></example>
        public SpliceAt (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Insert several values in to an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Hulk and Thor decide to join the avengers.</para>
/// <code>r.expr(["Iron Man", "Spider-Man"]).spliceAt(1, ["Hulk", "Thor"]).run(conn, callback)
/// </code></example>
        public SpliceAt (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Insert several values in to an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Hulk and Thor decide to join the avengers.</para>
/// <code>r.expr(["Iron Man", "Spider-Man"]).spliceAt(1, ["Hulk", "Thor"]).run(conn, callback)
/// </code></example>
        public SpliceAt (Arguments args, OptArgs optargs)
         : base(TermType.SPLICE_AT, args, optargs) {
        }


    



    


    

    


    
    }
}
