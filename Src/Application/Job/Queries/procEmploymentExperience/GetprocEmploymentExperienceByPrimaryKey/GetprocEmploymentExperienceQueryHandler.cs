using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEmploymentExperience.GetprocEmploymentExperienceByPrimaryKey
{
    public class GetprocEmploymentExperienceQueryHandler : IRequestHandler<GetprocEmploymentExperienceByPrimaryKey, GetprocEmploymentExperienceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEmploymentExperienceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmploymentExperienceLoadAllListVm> Handle(GetprocEmploymentExperienceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EmploymentExperience> procEmploymentExperiences = await _procedureAdabter
               .Execute<EmploymentExperience>("[Job].[proc_Employment_ExperienceLoadByPrimaryKey]", request);
            GetprocEmploymentExperienceLoadAllListVm vm = new GetprocEmploymentExperienceLoadAllListVm
            {
                procEmploymentExperiences = _mapper.Map<IList<EmploymentExperience>, IList<GetprocEmploymentExperienceLoadAllVm>>(procEmploymentExperiences)
            };

            return vm;
        }
    }
}
