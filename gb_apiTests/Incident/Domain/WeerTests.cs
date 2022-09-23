using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using OpenMeteoAPILib;

namespace gb_apiTests.Incident.Domain
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