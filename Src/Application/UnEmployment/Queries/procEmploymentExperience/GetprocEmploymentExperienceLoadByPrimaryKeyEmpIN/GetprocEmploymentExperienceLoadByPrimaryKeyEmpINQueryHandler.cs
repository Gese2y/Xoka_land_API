using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.UnEmployment.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procEmploymentExperience.GetprocEmploymentExperienceLoadByPrimaryKeyEmpIN
{
    public class GetprocEmploymentExperienceQueryHandler : IRequestHandler<GetprocEmploymentExperienceLoadByPrimaryKeyEmpIN, GetprocEmploymentExperienceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEmploymentExperienceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmploymentExperienceLoadAllListVm> Handle(GetprocEmploymentExperienceLoadByPrimaryKeyEmpIN request, CancellationToken cancellationToken)
        {
           
            IList<EmploymentExperience> procEmploymentExperiences = await _procedureAdabter
               .Execute<EmploymentExperience>("[UnEmployment].[proc_Employment_ExperienceLoadByPrimaryKey_Emp_IN]", request);
            GetprocEmploymentExperienceLoadAllListVm vm = new GetprocEmploymentExperienceLoadAllListVm
            {
                procEmploymentExperiences = _mapper.Map<IList<EmploymentExperience>, IList<GetprocEmploymentExperienceLoadAllVm>>(procEmploymentExperiences)
            };

            return vm;
        }
    }
}
