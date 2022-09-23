using Microsoft.VisualStudio.TestTools.UnitTesting;
using IncidentPackage.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gb_api.Incident.Domain;

namespace IncidentPackage.Domain.Tests
{
    [TestClass()]
    public class IncidentTests
    {
        [TestMethod()]
        public void IncidentTest()
        {
            var incident = new Incident(21);
            Debug.Assert(incident.Id == 21);
        }
    }
}