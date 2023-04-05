using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procJobSeeker.GetprocJobSeekerLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJobSeeker.GetprocJobSeekerByPrimaryKey
{
    public class GetprocJobSeekerQueryHandler : IRequestHandler<GetprocJobSeekerByPrimaryKey, GetprocJobSeekerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJobSeekerQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJobSeekerLoadAllListVm> Handle(GetprocJobSeekerByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JobSeeker> procJobSeekers = await _procedureAdabter
               .Execute<JobSeeker>("[Job].[proc_Job_SeekerLoadByPrimaryKey]", request);
            GetprocJobSeekerLoadAllListVm vm = new GetprocJobSeekerLoadAllListVm
            {
                procJobSeekers = _mapper.Map<IList<JobSeeker>, IList<GetprocJobSeekerLoadAllVm>>(procJobSeekers)
            };

            return vm;
        }
    }
}
