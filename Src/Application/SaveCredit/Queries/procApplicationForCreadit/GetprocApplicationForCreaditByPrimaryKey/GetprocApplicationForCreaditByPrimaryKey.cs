using MediatR;
using System.Collections.Generic;
using System.Text;
using Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditLoadAll;

namespace Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditByPrimaryKey
{
    /// @author  Shimels Alem proc_Application_For_CreaditLoadByPrimaryKey stored procedure.

    public class GetprocApplicationForCreaditByPrimaryKey : IRequest<GetprocApplicationForCreaditLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
