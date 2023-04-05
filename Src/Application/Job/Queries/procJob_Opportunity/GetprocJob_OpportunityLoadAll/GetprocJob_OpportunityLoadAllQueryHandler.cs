using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityLoadAll
{
    class GetprocJob_OpportunityLoadAllQueryHandler : IRequestHandler<GetprocJob_OpportunityLoadAllQuery, GetprocJob_OpportunityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJob_OpportunityLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_OpportunityLoadAllListVm> Handle(GetprocJob_OpportunityLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Job_Opportunity> procJob_Opportunitys = await _procedureAdabter
               .Execute<Job_Opportunity>("[Job].[proc_Job_OpportunityLoadAll]");
            GetprocJob_OpportunityLoadAllListVm vm = new GetprocJob_OpportunityLoadAllListVm
            {
                procJob_Opportunitys = _mapper.Map<IList<Job_Opportunity>, IList<GetprocJob_OpportunityLoadAllVm>>(procJob_Opportunitys)
            };

            return vm;
        }
    }
}
