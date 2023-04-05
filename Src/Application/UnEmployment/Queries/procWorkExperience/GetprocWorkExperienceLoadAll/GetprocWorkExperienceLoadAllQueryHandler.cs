using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceLoadAll
{
    class GetprocWorkExperienceLoadAllQueryHandler : IRequestHandler<GetprocWorkExperienceLoadAllQuery, GetprocWorkExperienceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocWorkExperienceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWorkExperienceLoadAllListVm> Handle(GetprocWorkExperienceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<WorkExperience> procWorkExperiences = await _procedureAdabter
               .Execute<WorkExperience>("[UnEmployment].[proc_Work_ExperienceLoadAll]");
            GetprocWorkExperienceLoadAllListVm vm = new GetprocWorkExperienceLoadAllListVm
            {
                procWorkExperiences = _mapper.Map<IList<WorkExperience>, IList<GetprocWorkExperienceLoadAllVm>>(procWorkExperiences)
            };

            return vm;
        }
    }
}
