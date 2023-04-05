

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procLoan.procLoanUpdate.procLoanUpdateCommand
{

    /// @author  Shimels Alem  proc_LoanUpdate stored procedure.


    public class procLoanUpdateHandler : IRequestHandler<procLoanUpdateCommand, IList<Loan_LoanId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLoanUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Loan_LoanId>> Handle( procLoanUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Loan_LoanId> result = await _procedureAdabter
                .Execute<Loan_LoanId>("[SaveCredit].proc_LoanUpdate", request);
           

            return result;
        }
    }
}
 