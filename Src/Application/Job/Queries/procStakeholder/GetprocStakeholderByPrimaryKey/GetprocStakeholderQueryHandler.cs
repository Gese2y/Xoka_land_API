using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procStakeholder.GetprocStakeholderLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procStakeholder.GetprocStakeholderByPrimaryKey
{
    public class GetprocStakeholderQueryHandler : IRequestHandler<GetprocStakeholderByPrimaryKey, GetprocStakeholderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocStakeholderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStakeholderLoadAllListVm> Handle(GetprocStakeholderByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Stakeholder> procStakeholders = await _procedureAdabter
               .Execute<Stakeholder>("[Job].[proc_StakeholderLoadByPrimaryKey]", request);
            GetprocStakeholderLoadAllListVm vm = new GetprocStakeholderLoadAllListVm
            {
                procStakeholders = _mapper.Map<IList<Stakeholder>, IList<GetprocStakeholderLoadAllVm>>(procStakeholders)
            };

            return vm;
        }
    }
}
