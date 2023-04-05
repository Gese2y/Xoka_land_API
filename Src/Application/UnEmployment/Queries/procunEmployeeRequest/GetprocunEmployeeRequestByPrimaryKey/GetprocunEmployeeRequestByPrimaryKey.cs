using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procunEmployeeRequest.GetprocunEmployeeRequestLoadAll;

namespace Application.UnEmployment.Quiries.procunEmployeeRequest.GetprocunEmployeeRequestByPrimaryKey
{
    /// @author  Shimels Alem proc_unEmployeeRequestLoadByPrimaryKey stored procedure.

    public class GetprocunEmployeeRequestByPrimaryKey : IRequest<GetprocunEmployeeRequestLoadAllListVm>
    {
        public System.Guid Id { get; set; }
    }
}
