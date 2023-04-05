namespace XOKA.Domain.Entities.Budget
{
    public class _Budget
    {
        public long Budget_ID { get; set; }
        public System.Guid? organization_code { get; set; }
        public int? Year { get; set; }
        public double? Total_Budget_Amount_In_Birr { get; set; }
        public System.Guid? StatusType { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string DocNo { get; set; }
        public string Log { get; set; }
    }
}
