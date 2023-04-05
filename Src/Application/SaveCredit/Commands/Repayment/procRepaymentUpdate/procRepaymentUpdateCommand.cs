using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.SaveCredit;


namespace Application.SaveCredit.Commands.Repayment.procRepaymentUpdate.procRepaymentUpdateCommand
{
    public class procRepaymentUpdateCommand : IRequest<IList<Repayment_ID>>
	{
        public System.Guid LoanID { get; set; }
        public System.Guid UserID { get; set; }
        public System.DateTime? RegistrationDate { get; set; }
        public string LoanAmount { get; set; }
        public string Repayments { get; set; }
        public string Balance { get; set; }

    }
}
