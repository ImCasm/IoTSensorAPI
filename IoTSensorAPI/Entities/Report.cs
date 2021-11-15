namespace IoTSensorAPI.Entities
{
    public class Report
    {
        public Guid? Id { get; set; }
        public DateTime? Date { get; set; }
        public float? Distance { get; set; }
        public string? UserId { get; set; }
        public User? User { get; set; }

    }
}
