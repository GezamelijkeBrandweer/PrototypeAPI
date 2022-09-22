namespace IncidentPackage.Domain
{
    public class Incident
    {
        private long id;
        private TimeSpan time;
        private string? name;

        public Incident(long id)
        {
            this.id = id;
        }

        public long Id { get { return id; } set { id = value; } }

    }
}