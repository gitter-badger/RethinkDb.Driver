












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

    public partial class PolygonSub : ReqlExpr {

    
    
    
/// <summary>
/// <para>Use <code>polygon2</code> to "punch out" a hole in <code>polygon1</code>. <code>polygon2</code> must be completely contained within <code>polygon1</code> and must have no holes itself (it must not be the output of <code>polygonSub</code> itself).</para>
/// </summary>
/// <example><para>Example: Define a polygon with a hole punched in it.</para>
/// <code>var outerPolygon = r.polygon(
///     [-122.4,37.7],
///     [-122.4,37.3],
///     [-121.8,37.3],
///     [-121.8,37.7]
/// );
/// var innerPolygon = r.polygon(
///     [-122.3,37.4],
///     [-122.3,37.6],
///     [-122.0,37.6],
///     [-122.0,37.4]
/// );
/// outerPolygon.polygonSub(innerpolygon).run(conn, callback);
/// </code></example>
        public PolygonSub (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Use <code>polygon2</code> to "punch out" a hole in <code>polygon1</code>. <code>polygon2</code> must be completely contained within <code>polygon1</code> and must have no holes itself (it must not be the output of <code>polygonSub</code> itself).</para>
/// </summary>
/// <example><para>Example: Define a polygon with a hole punched in it.</para>
/// <code>var outerPolygon = r.polygon(
///     [-122.4,37.7],
///     [-122.4,37.3],
///     [-121.8,37.3],
///     [-121.8,37.7]
/// );
/// var innerPolygon = r.polygon(
///     [-122.3,37.4],
///     [-122.3,37.6],
///     [-122.0,37.6],
///     [-122.0,37.4]
/// );
/// outerPolygon.polygonSub(innerpolygon).run(conn, callback);
/// </code></example>
        public PolygonSub (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Use <code>polygon2</code> to "punch out" a hole in <code>polygon1</code>. <code>polygon2</code> must be completely contained within <code>polygon1</code> and must have no holes itself (it must not be the output of <code>polygonSub</code> itself).</para>
/// </summary>
/// <example><para>Example: Define a polygon with a hole punched in it.</para>
/// <code>var outerPolygon = r.polygon(
///     [-122.4,37.7],
///     [-122.4,37.3],
///     [-121.8,37.3],
///     [-121.8,37.7]
/// );
/// var innerPolygon = r.polygon(
///     [-122.3,37.4],
///     [-122.3,37.6],
///     [-122.0,37.6],
///     [-122.0,37.4]
/// );
/// outerPolygon.polygonSub(innerpolygon).run(conn, callback);
/// </code></example>
        public PolygonSub (Arguments args, OptArgs optargs)
         : base(TermType.POLYGON_SUB, args, optargs) {
        }


    



    


    

    


    
    }
}
