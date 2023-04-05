using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Opportunity.GetprocJob_OpportunityByPrimaryKey
{
    public class GetprocJob_OpportunityQueryHandler : IRequestHandler<GetprocJob_OpportunityByPrimaryKey, GetprocJob_OpportunityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJob_OpportunityQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_OpportunityLoadAllListVm> Handle(GetprocJob_OpportunityByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Job_Opportunity> procJob_Opportunitys = await _procedureAdabter
               .Execute<Job_Opportunity>("[Job].[proc_Job_OpportunityLoadByPrimaryKey]", request);
            GetprocJob_OpportunityLoadAllListVm vm = new GetprocJob_OpportunityLoadAllListVm
            {
                procJob_Opportunitys = _mapper.Map<IList<Job_Opportunity>, IList<GetprocJob_OpportunityLoadAllVm>>(procJob_Opportunitys)
            };

            return vm;
        }
    }
}
