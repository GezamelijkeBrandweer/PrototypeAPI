using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace gb_apiTests.Incident.Domain
{
    [TestClass()]
    public class IncidentTests
    {
        [TestMethod()]
        public void IncidentTest()
        {
            var incident = new gb_api.Incident.Domain.Incident(21, "test");
            Debug.Assert(incident.Id == 21);
        }
    }
}