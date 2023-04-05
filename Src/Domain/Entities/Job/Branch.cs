namespace XOKA.Domain.Entities.Job
{
    public class Branch
	{
		public System.Guid ID { get; set; }
		public byte[]? Address { get; set; }
		public string Type { get; set; }
		public string Product { get; set; }

	}
}
