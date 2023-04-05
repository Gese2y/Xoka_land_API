namespace XOKA.Domain.Entities.TVET
{
    public class TVETlistCourse
	{
		public string Code { get; set; }
		public string Course_Name { get; set; }
		public bool? Is_Active { get; set; }
		public byte Credit_Hour { get; set; }
		public string prerequisites_Course { get; set; }
	}
}
