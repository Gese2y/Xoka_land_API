

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procAttendance.procAttendanceUpdate.procAttendanceUpdateCommand
{

    /// @author  Shimels Alem  proc_AttendanceUpdate stored procedure.


    public class procAttendanceUpdateHandler : IRequestHandler<procAttendanceUpdateCommand, IList<Attendance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAttendanceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Attendance_ID>> Handle( procAttendanceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Attendance_ID> result = await _procedureAdabter
                .Execute<Attendance_ID>("[TVET].proc_AttendanceUpdate", request);
           

            return result;
        }
    }
}
 