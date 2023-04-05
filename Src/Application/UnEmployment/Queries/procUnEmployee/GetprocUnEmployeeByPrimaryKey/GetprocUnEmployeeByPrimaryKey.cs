using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadAll;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeByPrimaryKey
{
    /// @author  Shimels Alem proc_UnEmployeeLoadByPrimaryKey stored procedure.

    public class GetprocUnEmployeeByPrimaryKey : IRequest<GetprocUnEmployeeLoadAllListVm>
    {
        public string TIN { get; set; }
    }
}
