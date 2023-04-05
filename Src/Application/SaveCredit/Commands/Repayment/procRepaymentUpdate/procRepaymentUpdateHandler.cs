
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.Repayment.procRepaymentUpdate.procRepaymentUpdateCommand
{
    public class procRepaymentUpdateHandler : IRequestHandler<procRepaymentUpdateCommand, IList<Repayment_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRepaymentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Repayment_ID>> Handle(procRepaymentUpdateCommand request, CancellationToken cancellationToken)
        {
            System.Guid LoanID = request.LoanID;
            System.Guid UserID = request.UserID;
            System.DateTime? RegistrationDate = request.RegistrationDate;
            string LoanAmount = request.LoanAmount;
            string Repayments = request.Repayments;
            string Balance = request.Balance;
            IList<Repayment_ID> result = await _procedureAdabter.Execute<Repayment_ID>("[Job].proc_tblRepaymentUpdate",
                (nameof(LoanID), LoanID),
                    (nameof(UserID), UserID),
                    (nameof(RegistrationDate), RegistrationDate),
                    (nameof(LoanAmount), LoanAmount),
                    (nameof(Repayments), Repayments),
                    (nameof(Balance), Balance)
                    );

            return result;
        }
    }
}
