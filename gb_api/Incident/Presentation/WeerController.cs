using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;
using OpenMeteoAPILib;

namespace gb_api.Incident.Presentation;

[ApiController]
[Route("/weer")]
public class WeerController : ControllerBase
{
    
    [HttpGet]
    public Task<JsonNode> GetWeerinformatie(double latitude, double longitude)
    {
        return OpenMeteo.GetWeerInfo(latitude, longitude);
    }
    
}