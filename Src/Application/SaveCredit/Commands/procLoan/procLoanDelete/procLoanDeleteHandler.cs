using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procLoan.procLoanDelete.procLoanDeleteCommand
{

    /// @author  Shimels Alem  proc_LoanDelete stored procedure.


    public class procLoanDeleteHandler : IRequestHandler<procLoanDeleteCommand, IList<Loan_LoanId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procLoanDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Loan_LoanId>> Handle( procLoanDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Loan_LoanId> result = await _procedureAdabter
                .Execute<Loan_LoanId>("[SaveCredit].proc_LoanDelete", request);
           

            return result;
        }
    }
}
  