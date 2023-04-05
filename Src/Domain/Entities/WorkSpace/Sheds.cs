using System.Spatial;

namespace XOKA.Domain.Entities.WorkSpace
{
    public class Sheds
	{
		public System.Guid ID { get; set; }
		public Geography? GEO_Location { get; set; }
		public string Type { get; set; }
		public int? Size { get; set; }
		public byte[] Pic { get; set; }
	}
}
