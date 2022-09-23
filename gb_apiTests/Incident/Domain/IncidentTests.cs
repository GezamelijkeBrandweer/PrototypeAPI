using System.Diagnostics;
using gb_api.Server.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gb_apiTests.Incident.Domain
{
    [TestClass()]
    public class IncidentTests
    {
        [TestMethod()]
        public void IncidentTest()
        {
            var locatie = new Locatie("3841VB", "dropsweg", 43, "Duiven", 55.23, 4.5541);
            var incident = new gb_api.Server.Domain.Incident(21, "Brand",locatie);
            Debug.Assert(incident.Id == 21);
        }
    }
}