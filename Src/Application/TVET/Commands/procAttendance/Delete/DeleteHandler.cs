using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procAttendance.procAttendanceDelete.procAttendanceDeleteCommand
{

    /// @author  Shimels Alem  proc_AttendanceDelete stored procedure.


    public class procAttendanceDeleteHandler : IRequestHandler<procAttendanceDeleteCommand, IList<Attendance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAttendanceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Attendance_ID>> Handle( procAttendanceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Attendance_ID> result = await _procedureAdabter
                .Execute<Attendance_ID>("[TVET].proc_AttendanceDelete", request);
           

            return result;
        }
    }
}
  