namespace MapsAPILib;

public class TrafficIncidentProperty
{
    public int iconCategory { get; }
    public DateTime startTime { get; }
    public DateTime? endTime { get; }
    public string from { get; }
    public string to { get; }
    public double length { get; }
    public int delay { get; }
    public List<object> roadNumbers { get; set; }
    public string timeValidity { get; set; }
    public string probabilityOfOccurrence { get; set; }
    public object numberOfReports { get; set; }
    public object lastReportTime { get; set; }
    public List<TrafficIncidentPropertyEvent> events { get; set; }
}