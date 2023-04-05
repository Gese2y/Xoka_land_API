using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMSEEmployee.GetprocMSEEmployeeLoadAll;

namespace Application.Job.Quiries.procMSEEmployee.GetprocMSEEmployeeLoadByPrimaryKeyMSETIN
{
    /// @author  Shimels Alem proc_MSE_EmployeeLoadByPrimaryKey_MSE_TIN stored procedure.

    public class GetprocMSEEmployeeLoadByPrimaryKeyMSETIN : IRequest<GetprocMSEEmployeeLoadAllListVm>
    {
        public string MSE_TIN { get; set; }
    }
}
