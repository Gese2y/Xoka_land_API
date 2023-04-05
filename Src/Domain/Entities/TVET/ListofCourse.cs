namespace XOKA.Domain.Entities.TVET
{
    public class ListofCourse
	{
		public System.Guid ID { get; set; }
		public string Course_Name { get; set; }
		public string IS_Active { get; set; }
		public System.Guid? TVET_ID { get; set; }
		public string Credit_Hour { get; set; }

	}
}
