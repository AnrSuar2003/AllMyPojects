namespace API3._0.Model.POSTGRESQL
{
    public class CalibratorTypePost
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string DrvName { get; set; }
        public int StabilizationTime { get; set; }
        public DateTime SyncDate { get; set; } = DateTime.UtcNow;
    }

}
