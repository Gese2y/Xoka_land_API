using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;


namespace Application.SaveCredit.Commands.Repayment.procRepaymentInsert.proRepaymentInsertCommand
{

    /// @author  Shimels Alem  proc_InstalmentsInsert stored procedure.


    public class proRepaymentInsertHandler : IRequestHandler<proRepaymentInsertCommand, IList<Repayment_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proRepaymentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Repayment_ID>> Handle(proRepaymentInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid LoanID = request.LoanID;
            System.Guid UserID = request.UserID;
            System.DateTime? RegistrationDate = request.RegistrationDate;
            string LoanAmount = request.LoanAmount;
            string Repayments = request.Repayments;
            string Balance = request.Balance;

            IList<Repayment_ID> result = await _procedureAdabter.Execute<Repayment_ID>("[Job].proc_tblRepaymentInsert",
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
