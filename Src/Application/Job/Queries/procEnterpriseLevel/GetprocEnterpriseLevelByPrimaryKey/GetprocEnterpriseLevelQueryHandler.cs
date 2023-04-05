using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procEnterpriseLevel.GetprocEnterpriseLevelLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEnterpriseLevel.GetprocEnterpriseLevelByPrimaryKey
{
    public class GetprocEnterpriseLevelQueryHandler : IRequestHandler<GetprocEnterpriseLevelByPrimaryKey, GetprocEnterpriseLevelLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnterpriseLevelQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseLevelLoadAllListVm> Handle(GetprocEnterpriseLevelByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EnterpriseLevel> procEnterpriseLevels = await _procedureAdabter
               .Execute<EnterpriseLevel>("[Job].[proc_Enterprise_LevelLoadByPrimaryKey]", request);
            GetprocEnterpriseLevelLoadAllListVm vm = new GetprocEnterpriseLevelLoadAllListVm
            {
                procEnterpriseLevels = _mapper.Map<IList<EnterpriseLevel>, IList<GetprocEnterpriseLevelLoadAllVm>>(procEnterpriseLevels)
            };

            return vm;
        }
    }
}
