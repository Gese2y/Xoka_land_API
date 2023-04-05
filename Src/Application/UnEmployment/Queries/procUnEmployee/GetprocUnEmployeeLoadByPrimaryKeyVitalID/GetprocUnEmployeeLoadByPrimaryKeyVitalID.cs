using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadAll;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadByPrimaryKeyVitalID
{
    /// @author  Shimels Alem proc_UnEmployeeLoadByPrimaryKey_Vital_ID stored procedure.

    public class GetprocUnEmployeeLoadByPrimaryKeyVitalID : IRequest<GetprocUnEmployeeLoadAllListVm>
    {
        public string Vital_ID { get; set; }
    }
}
