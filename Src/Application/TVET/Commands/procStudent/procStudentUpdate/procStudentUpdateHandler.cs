

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procStudent.procStudentUpdate.procStudentUpdateCommand
{

    /// @author  Shimels Alem  proc_StudentUpdate stored procedure.


    public class procStudentUpdateHandler : IRequestHandler<procStudentUpdateCommand, IList<Student_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStudentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Student_ID>> Handle( procStudentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Student_ID> result = await _procedureAdabter
                .Execute<Student_ID>("[TVET].proc_StudentUpdate", request);
           

            return result;
        }
    }
}
 