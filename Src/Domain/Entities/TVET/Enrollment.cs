

namespace XOKA.Domain.Entities.TVET
{
    public class Enrollment
	{
		public System.Guid EID { get; set; }
		public string Code { get; set; }
		public string Batch_ID { get; set; }
		public System.Guid? Student_ID { get; set; }
		public string Status{ get; set; }
	}
}
