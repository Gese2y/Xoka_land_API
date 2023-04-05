

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procListofCourse.procListofCourseUpdate.procListofCourseUpdateCommand
{

    /// @author  Shimels Alem  proc_List_of_CourseUpdate stored procedure.


    public class procListofCourseUpdateHandler : IRequestHandler<procListofCourseUpdateCommand, IList<ListofCourse_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procListofCourseUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ListofCourse_ID>> Handle( procListofCourseUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ListofCourse_ID> result = await _procedureAdabter
                .Execute<ListofCourse_ID>("[TVET].proc_List_of_CourseUpdate", request);
           

            return result;
        }
    }
}
 