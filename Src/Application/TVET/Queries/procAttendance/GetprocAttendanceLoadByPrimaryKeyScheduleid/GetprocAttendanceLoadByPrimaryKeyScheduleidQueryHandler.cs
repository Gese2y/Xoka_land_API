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

namespace Application.TVET.Quiries.procAttendance.GetprocAttendanceLoadByPrimaryKeyScheduleid
{
    public class GetprocAttendanceQueryHandler : IRequestHandler<GetprocAttendanceLoadByPrimaryKeyScheduleid, GetprocAttendanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAttendanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAttendanceLoadAllListVm> Handle(GetprocAttendanceLoadByPrimaryKeyScheduleid request, CancellationToken cancellationToken)
        {
           
            IList<Attendance> procAttendances = await _procedureAdabter
               .Execute<Attendance>("[TVET].[proc_AttendanceLoadByPrimaryKey_Schedule_id]", request);
            GetprocAttendanceLoadAllListVm vm = new GetprocAttendanceLoadAllListVm
            {
                procAttendances = _mapper.Map<IList<Attendance>, IList<GetprocAttendanceLoadAllVm>>(procAttendances)
            };

            return vm;
        }
    }
}
