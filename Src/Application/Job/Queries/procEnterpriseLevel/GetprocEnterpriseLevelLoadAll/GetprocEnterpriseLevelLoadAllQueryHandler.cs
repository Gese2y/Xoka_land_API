using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseLevel.GetprocEnterpriseLevelLoadAll
{
    class GetprocEnterpriseLevelLoadAllQueryHandler : IRequestHandler<GetprocEnterpriseLevelLoadAllQuery, GetprocEnterpriseLevelLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterpriseLevelLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseLevelLoadAllListVm> Handle(GetprocEnterpriseLevelLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EnterpriseLevel> procEnterpriseLevels = await _procedureAdabter
               .Execute<EnterpriseLevel>("[Job].[proc_Enterprise_LevelLoadAll]");
            GetprocEnterpriseLevelLoadAllListVm vm = new GetprocEnterpriseLevelLoadAllListVm
            {
                procEnterpriseLevels = _mapper.Map<IList<EnterpriseLevel>, IList<GetprocEnterpriseLevelLoadAllVm>>(procEnterpriseLevels)
            };

            return vm;
        }
    }
}
