namespace XOKA.Domain.Entities.Budget
{
    public class Budget_Type
    {
        public string Code { get; set; }
        public string Expenditure { get; set; }
        public string Description { get; set; }
        public string AccountCode { get; set; }
        public string Parent { get; set; }
        public System.Guid? For_organization { get; set; }
        public bool? Is_Account { get; set; }
    }
}
