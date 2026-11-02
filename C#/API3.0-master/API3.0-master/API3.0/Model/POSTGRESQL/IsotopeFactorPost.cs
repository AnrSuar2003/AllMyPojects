namespace API3._0.Model.POSTGRESQL
{
    public class IsotopeFactorPost
    {
        public int Id { get; set; }
        public int CalibratorTypeId { get; set; }
        public int IsotopeId { get; set; }
        public double Factor { get; set; }
        public DateTime SyncDate { get; set; } = DateTime.UtcNow;
    }

}
