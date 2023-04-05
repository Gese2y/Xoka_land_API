namespace XOKA.Domain.Entities.Trade
{
    public class OccupationalStandard
	{
		public string OS_ID { get; set; }
		public string Name { get; set; }
		public System.Guid? Parent { get; set; }
		public string Version { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public bool? IS_Active { get; set; }
	}
}
