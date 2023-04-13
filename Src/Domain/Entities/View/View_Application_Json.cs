using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Application_Json
    {
        public string application_number { get; set; }
        public Nullable<System.Guid> tasks_task_code { get; set; }
        public string Valuexml { get; set; }
        public string description_en { get; set; }
        public System.Guid task_type_code { get; set; }
        public System.Guid application_code { get; set; }
        public System.Guid process_detail_code { get; set; }
        public Nullable<System.Guid> services_service_code { get; set; }

    }
}
