using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJobSeeker.GetprocJobSeekerLoadAll
{
    class GetprocJobSeekerLoadAllQueryHandler : IRequestHandler<GetprocJobSeekerLoadAllQuery, GetprocJobSeekerLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJobSeekerLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJobSeekerLoadAllListVm> Handle(GetprocJobSeekerLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JobSeeker> procJobSeekers = await _procedureAdabter
               .Execute<JobSeeker>("[Job].[proc_Job_SeekerLoadAll]");
            GetprocJobSeekerLoadAllListVm vm = new GetprocJobSeekerLoadAllListVm
            {
                procJobSeekers = _mapper.Map<IList<JobSeeker>, IList<GetprocJobSeekerLoadAllVm>>(procJobSeekers)
            };

            return vm;
        }
    }
}
