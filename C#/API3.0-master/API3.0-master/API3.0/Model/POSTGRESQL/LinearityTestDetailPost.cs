namespace API3._0.Model.POSTGRESQL
{
    public class LinearityTestDetailPost
    {
        public int Id { get; set; }
        public int? LinearityTestId { get; set; }
        public double? ActivityExpected { get; set; }
        public double? ActivityRead { get; set; }
        public DateTime? TimeRead { get; set; }
        public DateTime SyncDate { get; set; } = DateTime.UtcNow;
    }
}
