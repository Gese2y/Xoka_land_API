



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procAttendance.procAttendanceInsert.procAttendanceInsertCommand
{

    /// @author  Shimels Alem  proc_AttendanceInsert stored procedure.


    public class procAttendanceInsertHandler : IRequestHandler<procAttendanceInsertCommand, IList<Attendance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAttendanceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Attendance_ID>> Handle( procAttendanceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Attendance_ID> result = await _procedureAdabter
                .Execute<Attendance_ID>("[TVET].proc_AttendanceInsert", request);
           

            return result;
        }
    }
}
 