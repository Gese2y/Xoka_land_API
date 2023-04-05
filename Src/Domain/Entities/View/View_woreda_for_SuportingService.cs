using System;

namespace XOKA.Domain.Entities.view
{
    public partial class View_woreda_for_SuportingService
    {
        public string Kebele_ID { get; set; }
        public Nullable<System.Guid> Woreda { get; set; }
        public Nullable<System.Guid> Zone { get; set; }
    }
}
