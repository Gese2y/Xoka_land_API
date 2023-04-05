using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadAll
{
    class GetprocEmploymentExperienceLoadAllQueryHandler : IRequestHandler<GetprocEmploymentExperienceLoadAllQuery, GetprocEmploymentExperienceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEmploymentExperienceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmploymentExperienceLoadAllListVm> Handle(GetprocEmploymentExperienceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EmploymentExperience> procEmploymentExperiences = await _procedureAdabter
               .Execute<EmploymentExperience>("[Job].[proc_Employment_ExperienceLoadAll]");
            GetprocEmploymentExperienceLoadAllListVm vm = new GetprocEmploymentExperienceLoadAllListVm
            {
                procEmploymentExperiences = _mapper.Map<IList<EmploymentExperience>, IList<GetprocEmploymentExperienceLoadAllVm>>(procEmploymentExperiences)
            };

            return vm;
        }
    }
}
