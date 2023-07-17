using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procApproved_For_Training.GetApproved_For_TrainingLoadAll;

namespace Application.TVET.Quiries.procApproved_For_Training.GetprocApproved_For_TrainingByVitalID
{
    /// @author  Shimels Alem proc_AttendanceLoadByPrimaryKey_Schedule_id stored procedure.

    public class GetprocApproved_For_TrainingByVitalIDcommond : IRequest<GetprocApproved_For_TrainingLoadAllListVm>
    {
        public string Vital_ID { get; set; }
    }
}
