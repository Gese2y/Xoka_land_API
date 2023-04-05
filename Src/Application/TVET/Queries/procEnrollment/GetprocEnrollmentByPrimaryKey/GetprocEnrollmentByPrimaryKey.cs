using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procEnrollment.GetprocEnrollmentLoadAll;

namespace Application.TVET.Quiries.procEnrollment.GetprocEnrollmentByPrimaryKey
{
    /// @author  Shimels Alem proc_EnrollmentLoadByPrimaryKey stored procedure.

    public class GetprocEnrollmentByPrimaryKey : IRequest<GetprocEnrollmentLoadAllListVm>
    {
        public System.Guid EID { get; set; }
    }
}
