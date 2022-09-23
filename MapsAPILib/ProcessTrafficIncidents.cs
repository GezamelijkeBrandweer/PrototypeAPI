using System.Text.Json;
using System.Text.Json.Nodes;

namespace MapsAPILib;

public class ProcessTrafficIncidents
{
    private readonly string _key;
    private readonly HttpClient _client;

    public ProcessTrafficIncidents(string apiKey, string url)
    {
        _key = apiKey;
        _client = new HttpClient()
        {
            BaseAddress = new Uri(url)
        };
    }

    public async Task<List<TrafficIncident>?> GetIncidentsIn(double[] longLatPairs)
    {
        //TODO uit een andres longtitude en latitude halen
        var bbox = "4.8854592519716675,52.36934334773164,4.897883244144765,52.37496348620152";
        
        var fields = "{incidents{geometry{type,coordinates},properties{iconCategory,events{description,code},startTime,endTime,from,to,length,delay,roadNumbers,timeValidity,probabilityOfOccurrence,numberOfReports,lastReportTime}}}";
        
        // events{description,code,iconCategory}
        
        using var response = await _client.GetAsync($"?bbox={bbox}&fields={fields}&language=en-GB&categoryFilter=0,1,2,3,4,5,6,7,8,9,10,11,14&timeValidityFilter=present&key={_key}");

        var jsonResponse = await response.Content.ReadAsStringAsync();
        var jsonResponseAsNode = JsonNode.Parse(jsonResponse);
        var filteredResponse = jsonResponseAsNode?["incidents"]?.ToJsonString();
        
        var incidents = JsonSerializer.Deserialize<List<TrafficIncident>>(filteredResponse);
        return incidents;
    }
}