using System;

namespace XOKA.Domain.Entities.view
{
    public class ViewBatch
    {
        public string Code { get; set; }
        public int Year { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string program_name { get; set; }
        public string Type { get; set; }
        public string Level { get; set; }
        public string provider_name { get; set; }
        public Nullable<int> Capacity { get; set; }
        public string ProviderCode { get; set; }

    }
}
