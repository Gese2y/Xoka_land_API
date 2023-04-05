using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procBusinessOppoForjobCreation.GetprocBusinessOppoForjobCreationByPrimaryKey
{
    public class GetprocBusinessOppoForjobCreationQueryHandler : IRequestHandler<GetprocBusinessOppoForjobCreationByPrimaryKey, GetprocBusinessOppoForjobCreationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBusinessOppoForjobCreationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBusinessOppoForjobCreationLoadAllListVm> Handle(GetprocBusinessOppoForjobCreationByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<BusinessOppoForjobCreation> procBusinessOppoForjobCreations = await _procedureAdabter
               .Execute<BusinessOppoForjobCreation>("[Job].[proc_Business_Oppo_For__job_CreationLoadByPrimaryKey]", request);
            GetprocBusinessOppoForjobCreationLoadAllListVm vm = new GetprocBusinessOppoForjobCreationLoadAllListVm
            {
                procBusinessOppoForjobCreations = _mapper.Map<IList<BusinessOppoForjobCreation>, IList<GetprocBusinessOppoForjobCreationLoadAllVm>>(procBusinessOppoForjobCreations)
            };

            return vm;
        }
    }
}
