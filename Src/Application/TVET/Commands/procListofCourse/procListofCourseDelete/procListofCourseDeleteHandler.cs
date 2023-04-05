using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procListofCourse.procListofCourseDelete.procListofCourseDeleteCommand
{

    /// @author  Shimels Alem  proc_List_of_CourseDelete stored procedure.


    public class procListofCourseDeleteHandler : IRequestHandler<procListofCourseDeleteCommand, IList<ListofCourse_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procListofCourseDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ListofCourse_ID>> Handle( procListofCourseDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ListofCourse_ID> result = await _procedureAdabter
                .Execute<ListofCourse_ID>("[TVET].proc_List_of_CourseDelete", request);
           

            return result;
        }
    }
}
  