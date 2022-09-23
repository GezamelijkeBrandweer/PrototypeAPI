using System.Text.Json.Nodes;
using BagAPILib;
using Microsoft.AspNetCore.Mvc;

namespace gb_api.Incident.Presentation;

[ApiController]
[Route("/bag")]
public class BagController : ControllerBase
{
    [HttpGet]
    public Task<JsonNode> BagCalls([FromQuery] string postcode, [FromQuery] int huisnummer)
    {
        return BagApiCalls.TestAdressenBag(postcode, huisnummer);
    }
}