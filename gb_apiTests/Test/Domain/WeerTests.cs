using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenMeteoAPILib;

namespace gb_apiTests.Test.Domain
{
    [TestClass()]
    public class WeerTests
    {
        [TestMethod()]
        public void WeerTest()
        {
            var weerInfo = OpenMeteo.GetWeerInfo(12, 12);
            Debug.Assert(weerInfo != null);
        }
    }
}