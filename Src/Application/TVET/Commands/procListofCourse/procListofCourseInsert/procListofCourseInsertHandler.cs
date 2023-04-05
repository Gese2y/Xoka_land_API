



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procListofCourse.procListofCourseInsert.procListofCourseInsertCommand
{

    /// @author  Shimels Alem  proc_List_of_CourseInsert stored procedure.


    public class procListofCourseInsertHandler : IRequestHandler<procListofCourseInsertCommand, IList<ListofCourse_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procListofCourseInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ListofCourse_ID>> Handle( procListofCourseInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ListofCourse_ID> result = await _procedureAdabter
                .Execute<ListofCourse_ID>("[TVET].proc_List_of_CourseInsert", request);
           

            return result;
        }
    }
}
 