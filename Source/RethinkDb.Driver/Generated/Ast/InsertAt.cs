












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

    public partial class InsertAt : ReqlExpr {

    
    
    
/// <summary>
/// <para>Insert a value in to an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Hulk decides to join the avengers.</para>
/// <code>r.expr(["Iron Man", "Spider-Man"]).insertAt(1, "Hulk").run(conn, callback)
/// </code></example>
        public InsertAt (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Insert a value in to an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Hulk decides to join the avengers.</para>
/// <code>r.expr(["Iron Man", "Spider-Man"]).insertAt(1, "Hulk").run(conn, callback)
/// </code></example>
        public InsertAt (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Insert a value in to an array at a given index. Returns the modified array.</para>
/// </summary>
/// <example><para>Example: Hulk decides to join the avengers.</para>
/// <code>r.expr(["Iron Man", "Spider-Man"]).insertAt(1, "Hulk").run(conn, callback)
/// </code></example>
        public InsertAt (Arguments args, OptArgs optargs)
         : base(TermType.INSERT_AT, args, optargs) {
        }


    



    


    

    


    
    }
}
