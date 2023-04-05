namespace XOKA.Domain.Entities.TVET
{
    public class TVETResult
	{
		public System.Guid RId { get; set; }
		public System.Guid? EID { get; set; }
		public System.Guid? Student_ID { get; set; }
		public string Total_Result { get; set; }
		public string Remark { get; set; }
		public bool? IsPass { get; set; }
	}
}
