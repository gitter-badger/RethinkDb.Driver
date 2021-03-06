




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Tests for basic usage of the add operation

    [TestFixture]
    public class MathLogicAdd : YamlTestFixture {

        public MathLogicAdd (){
        }




        [Test]
        public void YamlTest(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIzIiwiT3JpZ2luYWwiOiJyLmFkZCgxLCAxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuYWRkKDFMLCAxTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMiIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIyTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/add.yaml, #3
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.add(1, 1) */
                 var obtained = runOrCatch( r.add(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiI4IiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkgKyAxIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5hZGQoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjIiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMkwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/add.yaml, #8
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1) + 1 */
                 var obtained = runOrCatch( r.expr(1L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiI5IiwiT3JpZ2luYWwiOiIxICsgci5leHByKDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5hZGQoMUwsIHIuZXhwcigxTCkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjIiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMkwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/add.yaml, #9
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: 1 + r.expr(1) */
                 var obtained = runOrCatch( r.add(1L, r.expr(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIxMCIsIk9yaWdpbmFsIjoici5leHByKDEpLmFkZCgxKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuYWRkKDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIyIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjJMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/add.yaml, #10
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1).add(1) */
                 var obtained = runOrCatch( r.expr(1L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIxNiIsIk9yaWdpbmFsIjoici5leHByKC0xKSArIDEiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoLTFMKS5hZGQoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjAiLCJFeHBlY3RlZFR5cGUiOiJsb25nIiwiRXhwZWN0ZWRKYXZhIjoiMEwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/add.yaml, #16
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: r.expr(-1) + 1 */
                 var obtained = runOrCatch( r.expr(-1L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIyMSIsIk9yaWdpbmFsIjoici5leHByKDEuNzUpICsgOC41IiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDEuNzUpLmFkZCg4LjUpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjEwLjI1IiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiMTAuMjUiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/add.yaml, #21
                 /* ExpectedOriginal: 10.25 */
                 var expected_ = 10.25;
                 
                 /* Original: r.expr(1.75) + 8.5 */
                 var obtained = runOrCatch( r.expr(1.75).add(8.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIyNyIsIk9yaWdpbmFsIjoici5leHByKCcnKSArICcnIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKFwiXCIpLmFkZChcIlwiKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIiLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcIlwiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/add.yaml, #27
                 /* ExpectedOriginal:  */
                 var expected_ = "";
                 
                 /* Original: r.expr('') + '' */
                 var obtained = runOrCatch( r.expr("").add("") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIzMiIsIk9yaWdpbmFsIjoici5leHByKCdhYmMnKSArICdkZWYnIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKFwiYWJjXCIpLmFkZChcImRlZlwiKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJhYmNkZWYiLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcImFiY2RlZlwiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, math_logic/add.yaml, #32
                 /* ExpectedOriginal: abcdef */
                 var expected_ = "abcdef";
                 
                 /* Original: r.expr('abc') + 'def' */
                 var obtained = runOrCatch( r.expr("abc").add("def") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiIzOCIsIk9yaWdpbmFsIjoici5leHByKFsxLDJdKSArIFszXSArIFs0LDVdICsgWzYsNyw4XSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcihyLmFycmF5KDFMLCAyTCkpLmFkZChyLmFycmF5KDNMKSkuYWRkKHIuYXJyYXkoNEwsIDVMKSkuYWRkKHIuYXJyYXkoNkwsIDdMLCA4TCkpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IlsxLDIsMyw0LDUsNiw3LDhdIiwiRXhwZWN0ZWRUeXBlIjoiTGlzdCIsIkV4cGVjdGVkSmF2YSI6InIuYXJyYXkoMUwsIDJMLCAzTCwgNEwsIDVMLCA2TCwgN0wsIDhMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/add.yaml, #38
                 /* ExpectedOriginal: [1,2,3,4,5,6,7,8] */
                 var expected_ = r.array(1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L);
                 
                 /* Original: r.expr([1,2]) + [3] + [4,5] + [6,7,8] */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).add(r.array(3L)).add(r.array(4L, 5L)).add(r.array(6L, 7L, 8L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiI1MiIsIk9yaWdpbmFsIjoici5leHByKDEpICsgJ2EnIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS5hZGQoXCJhXCIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIE5VTUJFUiBidXQgZm91bmQgU1RSSU5HLlwiLCBbMV0pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkV4cGVjdGVkIHR5cGUgTlVNQkVSIGJ1dCBmb3VuZCBTVFJJTkcuXCIsIHIuYXJyYXkoMUwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/add.yaml, #52
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(1L));
                 
                 /* Original: r.expr(1) + 'a' */
                 var obtained = runOrCatch( r.expr(1L).add("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiI1NyIsIk9yaWdpbmFsIjoici5leHByKCdhJykgKyAxIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKFwiYVwiKS5hZGQoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIFNUUklORyBidXQgZm91bmQgTlVNQkVSLlwiLCBbMV0pIiwiRXhwZWN0ZWRUeXBlIjoiRXJyIiwiRXhwZWN0ZWRKYXZhIjoiZXJyKFwiUmVxbFF1ZXJ5TG9naWNFcnJvclwiLCBcIkV4cGVjdGVkIHR5cGUgU1RSSU5HIGJ1dCBmb3VuZCBOVU1CRVIuXCIsIHIuYXJyYXkoMUwpKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, math_logic/add.yaml, #57
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array(1L));
                 
                 /* Original: r.expr('a') + 1 */
                 var obtained = runOrCatch( r.expr("a").add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoibWF0aF9sb2dpYy9hZGQueWFtbCIsIkxpbmVOdW0iOiI2MiIsIk9yaWdpbmFsIjoici5leHByKFtdKSArIDEiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoci5hcnJheSgpKS5hZGQoMUwpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImVycihcIlJlcWxRdWVyeUxvZ2ljRXJyb3JcIiwgXCJFeHBlY3RlZCB0eXBlIEFSUkFZIGJ1dCBmb3VuZCBOVU1CRVIuXCIsIFsxXSkiLCJFeHBlY3RlZFR5cGUiOiJFcnIiLCJFeHBlY3RlZEphdmEiOiJlcnIoXCJSZXFsUXVlcnlMb2dpY0Vycm9yXCIsIFwiRXhwZWN0ZWQgdHlwZSBBUlJBWSBidXQgZm91bmQgTlVNQkVSLlwiLCByLmFycmF5KDFMKSkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, math_logic/add.yaml, #62
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type ARRAY but found NUMBER.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type ARRAY but found NUMBER.", r.array(1L));
                 
                 /* Original: r.expr([]) + 1 */
                 var obtained = runOrCatch( r.expr(r.array()).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
