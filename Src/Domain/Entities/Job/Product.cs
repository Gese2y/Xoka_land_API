namespace XOKA.Domain.Entities.Job
{
    public class Product
	{
		public System.Guid ID { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		public string Sector { get; set; }
		public string Sub_Sector { get; set; }
		public System.Guid? Parent { get; set; }
		public bool? IS_Active { get; set; }

	}
}
