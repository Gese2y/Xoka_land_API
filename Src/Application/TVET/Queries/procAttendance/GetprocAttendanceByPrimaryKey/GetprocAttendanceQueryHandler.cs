using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procAttendance.GetprocAttendanceLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procAttendance.GetprocAttendanceByPrimaryKey
{
    public class GetprocAttendanceQueryHandler : IRequestHandler<GetprocAttendanceByPrimaryKey, GetprocAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAttendanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAttendanceLoadAllListVm> Handle(GetprocAttendanceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Attendance> procAttendances = await _procedureAdabter
               .Execute<Attendance>("[TVET].[proc_AttendanceLoadByPrimaryKey]", request);
            GetprocAttendanceLoadAllListVm vm = new GetprocAttendanceLoadAllListVm
            {
                procAttendances = _mapper.Map<IList<Attendance>, IList<GetprocAttendanceLoadAllVm>>(procAttendances)
            };

            return vm;
        }
    }
}
