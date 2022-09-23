namespace MapsAPILib;

public class MapsApi
{
    private readonly string _key;
    private readonly string _baseUrl = "https://api.tomtom.com";

    public MapsApi(string? apiKey)
    {
        //_key = apiKey;
        _key = "ntW0IQTDLc9EBgSzbrmjTCR5DBrSuIgH";
    }

    public async Task<List<TrafficIncident>?> GetIncidentsIn(double[] longLatPairs)
    {
        var url = $"{_baseUrl}/traffic/services/5/incidentDetails";
        ProcessTrafficIncidents processTrafficIncidents = new(_key, url);
        
        List<TrafficIncident> incidents = await processTrafficIncidents.GetIncidentsIn(longLatPairs);
        return incidents;
    }
}