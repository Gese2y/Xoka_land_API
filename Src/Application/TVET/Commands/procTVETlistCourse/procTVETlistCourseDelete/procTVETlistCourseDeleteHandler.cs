using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procTVETlistCourse.procTVETlistCourseDelete.procTVETlistCourseDeleteCommand
{

    /// @author  Shimels Alem  proc_TVET_list_CourseDelete stored procedure.


    public class procTVETlistCourseDeleteHandler : IRequestHandler<procTVETlistCourseDeleteCommand, IList<TVETlistCourse_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTVETlistCourseDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TVETlistCourse_Code>> Handle( procTVETlistCourseDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<TVETlistCourse_Code> result = await _procedureAdabter
                .Execute<TVETlistCourse_Code>("[TVET].proc_TVET_list_CourseDelete", request);
           

            return result;
        }
    }
}
  