using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoLoadAll;

namespace Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoByPrimaryKey
{
    /// @author  Shimels Alem proc_UnEmployeeLoadByPrimaryKey stored procedure.

    public class GetprocUnEmployeeInfoByPrimaryKey : IRequest<GetprocUnEmployeeInfoLoadAllListVm>
    {
        public string Kebele_ID { get; set; }
    }
}
