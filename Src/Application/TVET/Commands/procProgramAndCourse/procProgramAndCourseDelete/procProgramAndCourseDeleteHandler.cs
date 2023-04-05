using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procProgramAndCourse.procProgramAndCourseDelete.procProgramAndCourseDeleteCommand
{

    /// @author  Shimels Alem  proc_Program_And_CourseDelete stored procedure.


    public class procProgramAndCourseDeleteHandler : IRequestHandler<procProgramAndCourseDeleteCommand, IList<ProgramAndCourse_PCID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProgramAndCourseDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProgramAndCourse_PCID>> Handle( procProgramAndCourseDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ProgramAndCourse_PCID> result = await _procedureAdabter
                .Execute<ProgramAndCourse_PCID>("[TVET].proc_Program_And_CourseDelete", request);
           

            return result;
        }
    }
}
  