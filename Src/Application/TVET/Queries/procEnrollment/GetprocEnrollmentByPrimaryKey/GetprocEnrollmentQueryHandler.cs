using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procEnrollment.GetprocEnrollmentLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procEnrollment.GetprocEnrollmentByPrimaryKey
{
    public class GetprocEnrollmentQueryHandler : IRequestHandler<GetprocEnrollmentByPrimaryKey, GetprocEnrollmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnrollmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnrollmentLoadAllListVm> Handle(GetprocEnrollmentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Enrollment> procEnrollments = await _procedureAdabter
               .Execute<Enrollment>("[TVET].[proc_EnrollmentLoadByPrimaryKey]", request);
            GetprocEnrollmentLoadAllListVm vm = new GetprocEnrollmentLoadAllListVm
            {
                procEnrollments = _mapper.Map<IList<Enrollment>, IList<GetprocEnrollmentLoadAllVm>>(procEnrollments)
            };

            return vm;
        }
    }
}
