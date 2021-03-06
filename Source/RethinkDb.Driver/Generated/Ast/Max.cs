












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

    public partial class Max : ReqlExpr {

    
    
    
/// <summary>
/// <para>Finds the maximum element of a sequence.</para>
/// </summary>
/// <example><para>Example: Return the maximum value in the list <code>[3, 5, 7]</code>.</para>
/// <code>r.expr([3, 5, 7]).max().run(conn, callback);
/// </code></example>
        public Max (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Finds the maximum element of a sequence.</para>
/// </summary>
/// <example><para>Example: Return the maximum value in the list <code>[3, 5, 7]</code>.</para>
/// <code>r.expr([3, 5, 7]).max().run(conn, callback);
/// </code></example>
        public Max (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Finds the maximum element of a sequence.</para>
/// </summary>
/// <example><para>Example: Return the maximum value in the list <code>[3, 5, 7]</code>.</para>
/// <code>r.expr([3, 5, 7]).max().run(conn, callback);
/// </code></example>
        public Max (Arguments args, OptArgs optargs)
         : base(TermType.MAX, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public Max this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Max (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
        public Max optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Max (this.Args, newOptargs);
        }


    

    


    
    }
}
