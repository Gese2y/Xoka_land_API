using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadAll;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID
{
    /// @author  Shimels Alem proc_UnEmployeeLoadByPrimaryKey_Vital_ID stored procedure.

    public class GetprocUnEmployeeinfoLoadByPrimaryKeyVitalID : IRequest<GetprocUnEmployeeinfoLoadAllListVm>
    {
        public string Vital_ID { get; set; }
    }
}
