using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procEnrollment.GetprocEnrollmentLoadAll
{
    class GetprocEnrollmentLoadAllQueryHandler : IRequestHandler<GetprocEnrollmentLoadAllQuery, GetprocEnrollmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnrollmentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnrollmentLoadAllListVm> Handle(GetprocEnrollmentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Enrollment> procEnrollments = await _procedureAdabter
               .Execute<Enrollment>("[TVET].[proc_EnrollmentLoadAll]");
            GetprocEnrollmentLoadAllListVm vm = new GetprocEnrollmentLoadAllListVm
            {
                procEnrollments = _mapper.Map<IList<Enrollment>, IList<GetprocEnrollmentLoadAllVm>>(procEnrollments)
            };

            return vm;
        }
    }
}
