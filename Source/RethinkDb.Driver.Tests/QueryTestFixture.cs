using NUnit.Framework;
using RethinkDb.Driver.Net;

namespace RethinkDb.Driver.Tests
{
    [TestFixture]
    public abstract class QueryTestFixture
    {
        protected const string DbName = "CSharpDriverTests";
        protected const string TableName = "TableA";

        public static RethinkDB r = RethinkDB.r;

        protected Connection conn;
        private void EnsureConnection()
        {
            if (conn == null || !conn.Open)
            {
                this.conn = r.connection()
                    .hostname(AppSettings.TestHost)
                    .port(AppSettings.TestPort)
                    .connect();
            }
        }


        private void SetupFluentAssertion()
        {
            //Hook into FluentAssertion so we see very useful 
            //YamlTest context information. TestLine, expected, got, etc...
            FluentAssertions.Common.Services.ResetToDefaults();
            var hook = FluentAssertions.Common.Services.ThrowException;
            FluentAssertions.Common.Services.ThrowException = s =>
                {
                    var logContext = TestLogContext.Context.ToString();
                    hook(logContext + s);
                };
        }

        [TestFixtureSetUp]
        public void BeforeRunningTestSession()
        {
            SetupFluentAssertion();
            EnsureConnection();

            try
            {
                CreateDb(DbName);
            }
            catch
            {
            }
        }

        [TestFixtureTearDown]
        public void AfterRunningTestSession()
        {
            try
            {
                DropDb(DbName);
            }
            catch
            {
            }
        }

        [SetUp]
        public void BeforeEachTest()
        {
            EnsureConnection();

            try
            {
                CreateTable(DbName, TableName);
            }
            catch
            {
            }
            TestLogContext.ResetContext();
        }

        [TearDown]
        public void AfterEachTest()
        {
            r.db("rethinkdb").table("_debug_scratch").delete().run(conn);
            if (!conn.Open)
            {
                conn.close();
                conn.reconnect();
            }
            conn.close(false);
        }

        protected void CreateDb(string dbName)
        {
            r.dbCreate(dbName).run(conn);
            r.db(dbName).wait_().run(conn);
        }

        protected void DropDb(string dbName)
        {
            r.dbDrop(dbName).run(conn);
        }

        protected void DropTable(string dbName, string tableName)
        {
            r.db(dbName).tableDrop(tableName).run(conn);
        }

        protected void CreateTable(string dbName, string tableName)
        {
            r.db(dbName).tableCreate(tableName).run(conn);
            r.db(dbName).table(tableName).wait_().run(conn);
        }
    }
}