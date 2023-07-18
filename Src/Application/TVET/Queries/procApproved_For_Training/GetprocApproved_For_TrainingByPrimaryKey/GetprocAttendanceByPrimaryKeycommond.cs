using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procApproved_For_Training.GetApproved_For_TrainingLoadAll;

namespace Application.TVET.Quiries.procApproved_For_Training.GetprocApproved_For_TrainingByPrimaryKey
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey stored procedure.

    public class GetprocAttendanceByPrimaryKeycommond : IRequest<GetprocApproved_For_TrainingLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
