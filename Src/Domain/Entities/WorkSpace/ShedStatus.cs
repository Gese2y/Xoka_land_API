using System.Spatial;

namespace XOKA.Domain.Entities.WorkSpace
{
    public class ShedStatus
	{
		public System.Guid ID { get; set; }
		public byte[] Stutus { get; set; }
		public Geography Construction_Place { get; set; }
		public System.Decimal? Cost { get; set; }
		public string Contactor { get; set; }
	}
}
