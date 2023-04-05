using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadAll
{
    class GetprocTVETResultLoadAllQueryHandler : IRequestHandler<GetprocTVETResultLoadAllQuery, GetprocTVETResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocTVETResultLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTVETResultLoadAllListVm> Handle(GetprocTVETResultLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<TVETResult> procTVETResults = await _procedureAdabter
               .Execute<TVETResult>("[TVET].[proc_TVET_ResultLoadAll]");
            GetprocTVETResultLoadAllListVm vm = new GetprocTVETResultLoadAllListVm
            {
                procTVETResults = _mapper.Map<IList<TVETResult>, IList<GetprocTVETResultLoadAllVm>>(procTVETResults)
            };

            return vm;
        }
    }
}
