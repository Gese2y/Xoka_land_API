using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceLoadAll;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procWorkExperience.GetprocWorkExperienceLoadByPrimaryKeyEMPTIN
{
    public class GetprocWorkExperienceQueryHandler : IRequestHandler<GetprocWorkExperienceLoadByPrimaryKeyEMPTIN, GetprocWorkExperienceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocWorkExperienceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWorkExperienceLoadAllListVm> Handle(GetprocWorkExperienceLoadByPrimaryKeyEMPTIN request, CancellationToken cancellationToken)
        {
           
            IList<WorkExperience> procWorkExperiences = await _procedureAdabter
               .Execute<WorkExperience>("[UnEmployment].[proc_Work_ExperienceLoadByPrimaryKey_EMP_TIN]", request);
            GetprocWorkExperienceLoadAllListVm vm = new GetprocWorkExperienceLoadAllListVm
            {
                procWorkExperiences = _mapper.Map<IList<WorkExperience>, IList<GetprocWorkExperienceLoadAllVm>>(procWorkExperiences)
            };

            return vm;
        }
    }
}
