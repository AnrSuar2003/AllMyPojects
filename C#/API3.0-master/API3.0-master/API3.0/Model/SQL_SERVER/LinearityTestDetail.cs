namespace API3._0.Model.SQL_SERVER
{
    public class LinearityTestDetail
    {
        public int Id { get; set; }
        public int? LinearityTestId { get; set; }
        public double? ActivityExpected { get; set; }
        public double? ActivityRead { get; set; }
        public DateTime? TimeRead { get; set; }
    }
}
