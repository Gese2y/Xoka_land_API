



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;


namespace Application.TVET.Commands.procTVETlistCourse.procTVETlistCourseInsert.procTVETlistCourseInsertCommand
{

    /// @author  Shimels Alem  proc_TVET_list_CourseInsert stored procedure.


    public class procTVETlistCourseInsertHandler : IRequestHandler<procTVETlistCourseInsertCommand, IList<TVETlistCourse_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTVETlistCourseInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TVETlistCourse_Code>> Handle( procTVETlistCourseInsertCommand request, CancellationToken cancellationToken)
        {
            string Code = request.Code;
            string Course_Name = request.Course_Name;
            bool? Is_Active = request.Is_Active;
            byte Credit_Hour = request.Credit_Hour;
            string prerequisites_Course = request.prerequisites_Course;
            IList<TVETlistCourse_Code> result = await _procedureAdabter
                    .Execute<TVETlistCourse_Code>("[TVET].proc_TVET_list_CourseInsert",
                    (nameof(Code), Code),
                    (nameof(Course_Name), Course_Name),
                    (nameof(Is_Active), Is_Active),
                    (nameof(Credit_Hour), Credit_Hour),
                    (nameof(prerequisites_Course), prerequisites_Course)
                    );

            return result;
        }
    }
}
 