using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadAll;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit
{
    public class GetprocLoanQueryHandler : IRequestHandler<GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit, GetprocLoanLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLoanQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLoanLoadAllListVm> Handle(GetprocLoanLoadByPrimaryKeyApplicationCodeCreadit request, CancellationToken cancellationToken)
        {
           
            IList<Loan> procLoans = await _procedureAdabter
               .Execute<Loan>("[SaveCredit].[proc_LoanLoadByPrimaryKey_ApplicationCodeCreadit]", request);
            GetprocLoanLoadAllListVm vm = new GetprocLoanLoadAllListVm
            {
                procLoans = _mapper.Map<IList<Loan>, IList<GetprocLoanLoadAllVm>>(procLoans)
            };

            return vm;
        }
    }
}
