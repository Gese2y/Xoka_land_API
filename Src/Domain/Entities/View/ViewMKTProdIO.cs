namespace XOKA.Domain.Entities.view
{
    public class ViewMKTProdIO
    {
        public System.Guid ID { get; set; }
        public string Opp_Name { get; set; }
        public string Name { get; set; }
        public bool? INPUT { get; set; }
        public bool? OUTPUT { get; set; }
        public string Unit { get; set; }
        public System.Int32? QTY { get; set; }
        public string Period { get; set; } 
        public System.Double? MIN_Price_With_Out_VAT_Birr { get; set; }
        public System.Double? MAX_Price { get; set; }
        
    }
}
