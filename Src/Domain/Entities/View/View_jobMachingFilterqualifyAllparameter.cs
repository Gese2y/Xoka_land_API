using System;

namespace XOKA.Domain.Entities.view
{
    public class View_jobMachingFilterqualifyAllparameter
    {
        public Guid Job_Opportunity_ID { get; set; }
        public Guid Woreda { get; set; }
        public Guid Sub_City { get; set; }
        public string QualifyBYAllParameter { get; set; }

        public DateTime Date_Expires { get; set; }

    }
}
