using System.Diagnostics;
using gb_api.Server.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gb_apiTests.Test.Domain
{
    [TestClass()]
    public class IncidentTests
    {
        [TestMethod()]
        public void IncidentTest()
        {
            var locatie = new Locatie("3841VB", "dropsweg", 43, "Duiven", 55.23, 4.5541);
            var weersinformatie = new Weersinformatie(); 
            var incident = new Incident(21, "Brand",locatie, weersinformatie);
            Debug.Assert(incident.Id == 21);
        }
    }
}