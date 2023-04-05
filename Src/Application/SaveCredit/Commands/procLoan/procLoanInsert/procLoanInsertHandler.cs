



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;


namespace Application.SaveCredit.Commands.procLoan.procLoanInsert.procLoanInsertCommand
{

    /// @author  Shimels Alem  proc_LoanInsert stored procedure.


    public class procLoanInsertHandler : IRequestHandler<procLoanInsertCommand, IList<Loan_LoanId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLoanInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Loan_LoanId>> Handle( procLoanInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Loan_LoanId> result = await _procedureAdabter
                .Execute<Loan_LoanId>("[SaveCredit].proc_LoanInsert", request);
           

            return result;
        }
    }
}
 