using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMSEEmployee.GetprocMSEEmployeeLoadAll;

namespace Application.Job.Quiries.procMSEEmployee.GetprocMSEEmployeeByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey stored procedure.

    public class GetprocMSEEmployeeByPrimaryKey : IRequest<GetprocMSEEmployeeLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
