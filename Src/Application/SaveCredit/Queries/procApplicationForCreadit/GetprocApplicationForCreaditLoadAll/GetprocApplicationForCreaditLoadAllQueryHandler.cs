using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditLoadAll
{
    class GetprocApplicationForCreaditLoadAllQueryHandler : IRequestHandler<GetprocApplicationForCreaditLoadAllQuery, GetprocApplicationForCreaditLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocApplicationForCreaditLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocApplicationForCreaditLoadAllListVm> Handle(GetprocApplicationForCreaditLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ApplicationForCreadit> procApplicationForCreadits = await _procedureAdabter
               .Execute<ApplicationForCreadit>("[SaveCredit].[proc_Application_For_CreaditLoadAll]");
            GetprocApplicationForCreaditLoadAllListVm vm = new GetprocApplicationForCreaditLoadAllListVm
            {
                procApplicationForCreadits = _mapper.Map<IList<ApplicationForCreadit>, IList<GetprocApplicationForCreaditLoadAllVm>>(procApplicationForCreadits)
            };

            return vm;
        }
    }
}
