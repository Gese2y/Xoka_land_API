namespace XOKA.Domain.Entities.TVET
{
    public class Attendance
	{
		public System.Guid ID { get; set; }
		public System.Guid? Schedule_id { get; set; }
		public System.DateTime? Date { get; set; }
		public bool? Is_Present { get; set; }
		public System.Guid? Student_ID { get; set; }

	}
}
