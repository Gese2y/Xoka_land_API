using MediatR;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditLoadAll;

namespace Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditLoadByPrimaryKeyTIN
{
    /// @author  Shimels Alem proc_Application_For_CreaditLoadByPrimaryKey_TIN stored procedure.

    public class GetprocApplicationForCreaditLoadByPrimaryKeyTIN : IRequest<GetprocApplicationForCreaditLoadAllListVm>
    {
        public long TIN { get; set; }
    }
}
