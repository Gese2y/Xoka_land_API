

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Commands.procProgramAndCourse.procProgramAndCourseUpdate.procProgramAndCourseUpdateCommand
{

    /// @author  Shimels Alem  proc_Program_And_CourseUpdate stored procedure.


    public class procProgramAndCourseUpdateHandler : IRequestHandler<procProgramAndCourseUpdateCommand, IList<ProgramAndCourse_PCID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProgramAndCourseUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProgramAndCourse_PCID>> Handle( procProgramAndCourseUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ProgramAndCourse_PCID> result = await _procedureAdabter
                .Execute<ProgramAndCourse_PCID>("[TVET].proc_Program_And_CourseUpdate", request);

            return result;
        }
    }
}
 