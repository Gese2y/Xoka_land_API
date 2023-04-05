namespace XOKA.Domain.Entities.WorkSpace
{
    public class LocationforBusOPP
	{
		public System.Guid BUS_OPP_Loc_Code { get; set; }
		public System.Guid BUS_OPP_ID { get; set; }
		public System.Guid Region { get; set; }
		public System.Guid Zone { get; set; }
		public System.Guid Woreda { get; set; }
		public int JobOpen_For_ENT { get; set; }
		public int Job_Open_For_Job_Seeker { get; set; }
		public string Remark { get; set; }
	}
}
