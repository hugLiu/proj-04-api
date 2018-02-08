using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GTAPI.Oracle.DataBase;

namespace GTAPI.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = 1;
            string t = OracleAccess.ConnectOracle();
        }
    }
}
