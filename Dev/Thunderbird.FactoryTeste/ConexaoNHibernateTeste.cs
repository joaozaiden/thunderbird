using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thunderbird.Factory.Entity;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Thunderbird.FactoryTeste
{
    /// <summary>
    /// Summary description for ConexaoNHibernateTeste
    /// </summary>
    [TestClass]
    public class ConexaoNHibernateTeste
    {
        public ConexaoNHibernateTeste()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        public void GerarScript()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Aluno).Assembly);

            var schemaExport = new SchemaExport(cfg);
            schemaExport.Create(true, false);
        }

        [TestMethod]
        public void GerarDataBase()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Aluno).Assembly);

            var schemaExport = new SchemaExport(cfg);
            schemaExport.Create(true, true);
        }
    }
}
