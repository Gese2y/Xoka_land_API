using System;

namespace XOKA.Domain.Entities.view
{
    public class View_BatchwithEnrollment
    {
        public string ProviderCode { get; set; }
        public Nullable<int> Capac { get; set; }
        public string Student_code { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public int Year { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public string program_name { get; set; }
        public string provider_name { get; set; }
        public System.Guid ID { get; set; }
        public System.Guid EID { get; set; }

    }
}
