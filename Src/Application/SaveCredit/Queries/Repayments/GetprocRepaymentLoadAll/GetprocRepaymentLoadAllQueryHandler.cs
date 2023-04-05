using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;
using Application.SaveCredit.Quiries.Repayments;

namespace Application.SaveCredit.Queries.Repayments.GetprocRepaymentLoadAll
{
    public class GetprocRepaymentLoadAllQueryHandler : IRequestHandler<GetprocRepaymentLoadAllQuery, GetprocRepaymentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocRepaymentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocRepaymentLoadAllListVm> Handle(GetprocRepaymentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Repayment> procRepayments = await _procedureAdabter
               .Execute<Repayment>("[Job].[proc_tblRepaymentLoadAll]");
            GetprocRepaymentLoadAllListVm vm = new GetprocRepaymentLoadAllListVm
            {
                procRepayments = _mapper.Map<IList<Repayment>, IList<GetprocRepaymentLoadAllVm>>(procRepayments)
                                                                     
            };

            return vm;
        }
    }
}
