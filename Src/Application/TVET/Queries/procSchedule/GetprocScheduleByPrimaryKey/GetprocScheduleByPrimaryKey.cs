using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procSchedule.GetprocScheduleLoadAll;

namespace Application.TVET.Quiries.procSchedule.GetprocScheduleByPrimaryKey
{
    /// @author  Shimels Alem proc_ScheduleLoadByPrimaryKey stored procedure.

    public class GetprocScheduleByPrimaryKey : IRequest<GetprocScheduleLoadAllListVm>
    {
        public System.Guid SID { get; set; }
    }
}
