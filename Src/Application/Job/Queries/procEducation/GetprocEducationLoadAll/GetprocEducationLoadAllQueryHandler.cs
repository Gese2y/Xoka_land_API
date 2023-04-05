using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procEducation.GetprocEducationLoadAll
{
    class GetprocEducationLoadAllQueryHandler : IRequestHandler<GetprocEducationLoadAllQuery, GetprocEducationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEducationLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEducationLoadAllListVm> Handle(GetprocEducationLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Education> procEducations = await _procedureAdabter
               .Execute<Education>("[Job].[proc_EducationLoadAll]");
            GetprocEducationLoadAllListVm vm = new GetprocEducationLoadAllListVm
            {
                procEducations = _mapper.Map<IList<Education>, IList<GetprocEducationLoadAllVm>>(procEducations)
            };

            return vm;
        }
    }
}
