using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procLoan.GetprocLoanLoadAll
{
    class GetprocLoanLoadAllQueryHandler : IRequestHandler<GetprocLoanLoadAllQuery, GetprocLoanLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLoanLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLoanLoadAllListVm> Handle(GetprocLoanLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Loan> procLoans = await _procedureAdabter
               .Execute<Loan>("[SaveCredit].[proc_LoanLoadAll]");
            GetprocLoanLoadAllListVm vm = new GetprocLoanLoadAllListVm
            {
                procLoans = _mapper.Map<IList<Loan>, IList<GetprocLoanLoadAllVm>>(procLoans)
            };

            return vm;
        }
    }
}
