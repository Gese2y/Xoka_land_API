using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procEducation.GetprocEducationLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEducation.GetprocEducationByPrimaryKey
{
    public class GetprocEducationQueryHandler : IRequestHandler<GetprocEducationByPrimaryKey, GetprocEducationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEducationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEducationLoadAllListVm> Handle(GetprocEducationByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Education> procEducations = await _procedureAdabter
               .Execute<Education>("[Job].[proc_EducationLoadByPrimaryKey]", request);
            GetprocEducationLoadAllListVm vm = new GetprocEducationLoadAllListVm
            {
                procEducations = _mapper.Map<IList<Education>, IList<GetprocEducationLoadAllVm>>(procEducations)
            };

            return vm;
        }
    }
}
