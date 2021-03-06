












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

    public partial class Uuid : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return a UUID (universally unique identifier), a string that can be used as a unique ID.</para>
/// </summary>
/// <example><para>Example: Generate a UUID.</para>
/// <code>&gt; r.uuid().run(conn, callback)
/// // result returned to callback
/// 27961a0e-f4e8-4eb3-bf95-c5203e1d87b9
/// </code></example>
        public Uuid (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return a UUID (universally unique identifier), a string that can be used as a unique ID.</para>
/// </summary>
/// <example><para>Example: Generate a UUID.</para>
/// <code>&gt; r.uuid().run(conn, callback)
/// // result returned to callback
/// 27961a0e-f4e8-4eb3-bf95-c5203e1d87b9
/// </code></example>
        public Uuid (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return a UUID (universally unique identifier), a string that can be used as a unique ID.</para>
/// </summary>
/// <example><para>Example: Generate a UUID.</para>
/// <code>&gt; r.uuid().run(conn, callback)
/// // result returned to callback
/// 27961a0e-f4e8-4eb3-bf95-c5203e1d87b9
/// </code></example>
        public Uuid (Arguments args, OptArgs optargs)
         : base(TermType.UUID, args, optargs) {
        }


    



    


    

    


    
    }
}
