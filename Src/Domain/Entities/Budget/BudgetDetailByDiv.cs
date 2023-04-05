namespace XOKA.Domain.Entities.Budget
{
    public class Budget_DetailByDiv
    {
        public string Budget_DetailID { get; set; }
        public long Budget_ID { get; set; }
        public string Budget_Type { get; set; }
        public System.Guid DIV_code { get; set; }
        public string Unit { get; set; }
        public System.Guid? ParentBuget_Detail_ID { get; set; }
        public bool? Is_Approved { get; set; }
        public double? Budget_Ammount_Birr { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public string DocNo { get; set; }
        public string Log { get; set; }
    }
}
