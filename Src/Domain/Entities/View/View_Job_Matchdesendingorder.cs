using System;

namespace XOKA.Domain.Entities.view
{

    public partial class View_Job_Matchdesendingorder
    {
        public System.Guid Job_Match_ID { get; set; }
        public Nullable<System.Guid> Transaction_ID { get; set; }
        public string Kebele_ID { get; set; }
        public string Officer_Proposed_Kebele_ID { get; set; }
        public string Officer_Justification { get; set; }
        public Nullable<System.DateTime> Date_Proposed { get; set; }
        public Nullable<bool> Is_Approved { get; set; }
        public string Approval_Justification_Doc { get; set; }
        public string Hired_Justification_Doc { get; set; }
        public Nullable<bool> Is_Hired { get; set; }
        public string Remarks { get; set; }
        public string Full_Name { get; set; }
        public string? Gender { get; set; }
        public string? Sex { get; set; }
        public int? Age { get; set; }
        public string? Education_Level { get; set; }
        public string? Education_Level_Name { get; set; }
        public string? Eduction_Types { get; set; }
        public string? english_description { get; set; }
        public string? Zone_SubCity { get; set; }
        public string? Woreda_Kebele { get; set; }
        public string? Parent { get; set; }
    }
}
