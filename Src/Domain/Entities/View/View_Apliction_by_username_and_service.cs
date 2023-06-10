using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Apliction_by_username_and_service
    {
        public string application_number { get; set; } 
        public Guid application_code { get; set; } 
        public string UserName { get; set; } 
        public Guid UserId { get; set; }
        public Guid services_service_code { get; set; }
        public Guid organization_code { get; set; }


    }
}
