using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procStudent.procStudentDelete.procStudentDeleteCommand
{

    /// @author  Shimels Alem  proc_StudentDelete stored procedure.


    public class procStudentDeleteHandler : IRequestHandler<procStudentDeleteCommand, IList<Student_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStudentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Student_ID>> Handle( procStudentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Student_ID> result = await _procedureAdabter
                .Execute<Student_ID>("[TVET].proc_StudentDelete", request);
           

            return result;
        }
    }
}
  