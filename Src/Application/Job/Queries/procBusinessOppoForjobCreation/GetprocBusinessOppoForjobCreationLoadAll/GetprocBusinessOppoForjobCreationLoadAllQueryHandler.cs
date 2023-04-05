using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationLoadAll
{
    class GetprocBusinessOppoForjobCreationLoadAllQueryHandler : IRequestHandler<GetprocBusinessOppoForjobCreationLoadAllQuery, GetprocBusinessOppoForjobCreationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBusinessOppoForjobCreationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBusinessOppoForjobCreationLoadAllListVm> Handle(GetprocBusinessOppoForjobCreationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<BusinessOppoForjobCreation> procBusinessOppoForjobCreations = await _procedureAdabter
               .Execute<BusinessOppoForjobCreation>("[Job].[proc_Business_Oppo_For__job_CreationLoadAll]");
            GetprocBusinessOppoForjobCreationLoadAllListVm vm = new GetprocBusinessOppoForjobCreationLoadAllListVm
            {
                procBusinessOppoForjobCreations = _mapper.Map<IList<BusinessOppoForjobCreation>, IList<GetprocBusinessOppoForjobCreationLoadAllVm>>(procBusinessOppoForjobCreations)
            };

            return vm;
        }
    }
}
