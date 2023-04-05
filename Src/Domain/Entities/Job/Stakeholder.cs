using System;

namespace XOKA.Domain.Entities.Job
{
    public class Stakeholder
    {
        public string Stakeholder_TIN { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type_Of_Stakeholder { get; set; }
        public Nullable<bool> Is_SME { get; set; }

    }
}
