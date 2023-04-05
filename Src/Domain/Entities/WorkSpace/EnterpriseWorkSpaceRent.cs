namespace XOKA.Domain.Entities.WorkSpace
{
    public class EnterpriseWorkSpaceRent
	{
		public System.Guid Work_Space_ID { get; set; }
		public string TIN { get; set; }
		public System.Guid? EAFW_ID { get; set; }
		public System.Double? Monthly_Price { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public byte[] Contract_Doc { get; set; }
		public string EWSR_Status { get; set; }
		public bool? Is_Active { get; set; }
		public System.Guid? Parent { get; set; }
	}
}
