using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procAttendance.GetprocAttendanceLoadAll;

namespace Application.TVET.Quiries.procAttendance.GetprocAttendanceByPrimaryKey
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey stored procedure.

    public class GetprocAttendanceByPrimaryKey : IRequest<GetprocAttendanceLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
