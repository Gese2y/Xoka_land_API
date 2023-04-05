using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.TVET.Quiries.procStudent.GetprocStudentLoadAll;

namespace Application.TVET.Quiries.procStudent.GetprocStudentByPrimaryKey
{
    /// @author  Shimels Alem proc_StudentLoadByPrimaryKey stored procedure.

    public class GetprocStudentByPrimaryKey : IRequest<GetprocStudentLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
