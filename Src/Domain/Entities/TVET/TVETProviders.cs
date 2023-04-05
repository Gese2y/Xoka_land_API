namespace XOKA.Domain.Entities.TVET
{
    public class TVETProviders
	{
		public string ProviderCode { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string X { get; set; }
		public string Y { get; set; }
		public int? Capacity { get; set; }
		public bool? IS_Active { get; set; }
		public System.Guid? Org_Code { get; set; }
	}
}
