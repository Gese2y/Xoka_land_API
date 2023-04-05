
using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;
namespace Application.SaveCredit.Commands.Repayment.procRepaymentDelete.procRepaymentDeleteCommand
{
    public  class procRepaymentDeleteCommand : IRequest<IList<Repayment_ID>>
    {

        public System.Guid LoanID { get; set; }
    }

}
