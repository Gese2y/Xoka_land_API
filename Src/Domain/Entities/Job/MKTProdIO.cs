namespace XOKA.Domain.Entities.Job
{
    public class MKTProdIO
	{
       public System.Guid ID { get; set; }
        public System.Guid? OPP_ID { get; set; }
        public System.Guid? Product_ID { get; set; }
        public bool? INPUT { get; set; }
        public bool? OUTPUT { get; set; }
        public string Unit { get; set; }
        public System.Int32? QTY { get; set; }
        public string Period { get; set; }
        public System.Double? MIN_Price_With_Out_VAT_Birr { get; set; }
        public System.Double? MIX_Price_With_OUT_VAT_Birr { get; set; }
	}
}
