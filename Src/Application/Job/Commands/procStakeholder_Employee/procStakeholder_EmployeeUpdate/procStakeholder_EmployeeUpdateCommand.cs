using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procStakeholder_Employee.procStakeholder_EmployeeUpdate.procStakeholder_EmployeeUpdateCommand
{

	/// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.

	public class procStakeholder_EmployeeUpdateCommand : IRequest<IList<Stakeholder_Employee_Id>>
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
        public DateTime TerminatedDate { get; set; }

    }



}

