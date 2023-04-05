using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Quiries.procStakeholder_Employee
{
    public class GetprocStakeholder_EmployeeLoadAllVm : IMapFrom<Stakeholder_Employee>
    {
        public System.Guid Stakeholder_Employee_ID { get; set; }
        public string Stakeholder_TIN { get; set; }
        public string Employee_TIN { get; set; }
        public string Full_Name { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
        public string Education_Level { get; set; }
        public Nullable<decimal> Basic_Salary { get; set; }
        public Nullable<System.DateTime> Date_Hired { get; set; }
        public string Hire_Type { get; set; }
        public Nullable<bool> Is_Disabled { get; set; }
        public Nullable<bool> Is_Refugee { get; set; }
        public Nullable<bool> Is_Returnee { get; set; }
        public Nullable<bool> Has_HIV { get; set; }
        public string Employee_Status { get; set; }
        public string Kebele_ID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Stakeholder_Employee, GetprocStakeholder_EmployeeLoadAllVm>();
        }
    }
}
