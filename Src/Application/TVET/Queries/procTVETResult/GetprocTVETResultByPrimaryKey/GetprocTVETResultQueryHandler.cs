using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procTVETResult.GetprocTVETResultLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procTVETResult.GetprocTVETResultByPrimaryKey
{
    public class GetprocTVETResultQueryHandler : IRequestHandler<GetprocTVETResultByPrimaryKey, GetprocTVETResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTVETResultQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTVETResultLoadAllListVm> Handle(GetprocTVETResultByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<TVETResult> procTVETResults = await _procedureAdabter
               .Execute<TVETResult>("[TVET].[proc_TVET_ResultLoadByPrimaryKey]", request);
            GetprocTVETResultLoadAllListVm vm = new GetprocTVETResultLoadAllListVm
            {
                procTVETResults = _mapper.Map<IList<TVETResult>, IList<GetprocTVETResultLoadAllVm>>(procTVETResults)
            };

            return vm;
        }
    }
}
