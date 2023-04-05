using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Tax.Quiries.procEmployeeTINInfo.GetprocEmployeeTINInfoLoadAll;

namespace Application.Tax.Quiries.procEmployeeTINInfo.GetprocEmployeeTINInfoByPrimaryKey
{
    /// @author  Shimels Alem proc_Employee_TIN_InfoLoadByPrimaryKey stored procedure.

    public class GetprocEmployeeTINInfoByPrimaryKey : IRequest<GetprocEmployeeTINInfoLoadAllListVm>
    {
        public System.Guid Emp_TIN_ID { get; set; }
    }
}
