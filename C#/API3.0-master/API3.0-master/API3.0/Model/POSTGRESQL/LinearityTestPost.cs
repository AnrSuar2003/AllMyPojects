namespace API3._0.Model.POSTGRESQL
{
    public class LinearityTestPost
    {
        public int Id { get; set; }
        public int? IsotopeId { get; set; }
        public int CalibratorTypeId { get; set; }
        public bool? Completed { get; set; }
        public double? Length { get; set; }
        public double? Delta { get; set; }
        public DateTime? Date { get; set; }
        public DateTime SyncDate { get; set; } 
    }
}
