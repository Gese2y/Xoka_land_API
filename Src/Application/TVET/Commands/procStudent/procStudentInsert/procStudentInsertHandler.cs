



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procStudent.procStudentInsert.procStudentInsertCommand
{

    /// @author  Shimels Alem  proc_StudentInsert stored procedure.


    public class procStudentInsertHandler : IRequestHandler<procStudentInsertCommand, IList<Student_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStudentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Student_ID>> Handle( procStudentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Student_ID> result = await _procedureAdabter
                .Execute<Student_ID>("[TVET].proc_StudentInsert", request);
           

            return result;
        }
    }
}
 