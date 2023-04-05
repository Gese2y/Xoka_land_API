using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procStakeholder_Employee.GetprocStakeholder_EmployeeLoadAll;

namespace Application.Job.Quiries.procStakeholder_Employee.GetprocStakeholder_EmployeeByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocStakeholder_EmployeeByPrimaryKey : IRequest<GetprocStakeholder_EmployeeLoadAllListVm>
    {
        public System.Guid Stakeholder_Employee_ID { get; set; }
       

    }
}
