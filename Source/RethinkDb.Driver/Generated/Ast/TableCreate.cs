












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

    public partial class TableCreate : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a table. A RethinkDB table is a collection of JSON documents.</para>
/// </summary>
/// <example><para>Example: Create a table named 'dc_universe' with the default settings.</para>
/// <code>r.db('test').tableCreate('dc_universe').run(conn, callback)
/// </code></example>
        public TableCreate (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a table. A RethinkDB table is a collection of JSON documents.</para>
/// </summary>
/// <example><para>Example: Create a table named 'dc_universe' with the default settings.</para>
/// <code>r.db('test').tableCreate('dc_universe').run(conn, callback)
/// </code></example>
        public TableCreate (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a table. A RethinkDB table is a collection of JSON documents.</para>
/// </summary>
/// <example><para>Example: Create a table named 'dc_universe' with the default settings.</para>
/// <code>r.db('test').tableCreate('dc_universe').run(conn, callback)
/// </code></example>
        public TableCreate (Arguments args, OptArgs optargs)
         : base(TermType.TABLE_CREATE, args, optargs) {
        }


    



    
///<summary>
/// "primary_key": "T_STR",
///  "durability": "E_DURABILITY",
///  "shards": "T_NUM",
///  "replicas": [
///    "T_NUM",
///    "T_OBJECT"
///  ],
///  "primary_replica_tag": "T_STR"
///</summary>
        public TableCreate this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new TableCreate (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "primary_key": "T_STR",
///  "durability": "E_DURABILITY",
///  "shards": "T_NUM",
///  "replicas": [
///    "T_NUM",
///    "T_OBJECT"
///  ],
///  "primary_replica_tag": "T_STR"
///</summary>
        public TableCreate optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new TableCreate (this.Args, newOptargs);
        }


    

    


    
    }
}
