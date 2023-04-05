namespace XOKA.Domain.Entities.TVET
{
    public class ShortTermTraining
	{
		public System.Guid ID { get; set; }
		public string EMP_TIN { get; set; }
		public string Training_Type { get; set; }
		public string Instiutution { get; set; }
		public int? Passmark { get; set; }
		public System.Guid? Doc_ID { get; set; }
		public string Training_Name { get; set; }
	}
}
