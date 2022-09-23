namespace gb_api.Incident.Domain
{
    public class Weersinformatie
    {
        public List<string> Time { get; set; }

        public List<double> Temperature { get; set; }

        public List<double> Humidity { get; set; }

        public List<double> Rain { get; set; }

        public List<double> Windspeed { get; set; }

        public List<double> Winddirection { get; set; }

        public List<double> Windgusts { get; set; }


        public Weersinformatie()
        {

        }

        public Weersinformatie(List<string> time, List<double> temperature, List<double> humidity, List<double> rain, List<double> windspeed, List<double> winddirection, List<double> windgusts)
        {
            this.Time = time;
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Rain = rain;
            this.Windspeed = windspeed;
            this.Winddirection = winddirection;
            this.Windgusts = windgusts;
        }

    }
}
