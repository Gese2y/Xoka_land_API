using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procProgramAndCourse.GetprocProgramAndCourseLoadAll
{
    class GetprocProgramAndCourseLoadAllQueryHandler : IRequestHandler<GetprocProgramAndCourseLoadAllQuery, GetprocProgramAndCourseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProgramAndCourseLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProgramAndCourseLoadAllListVm> Handle(GetprocProgramAndCourseLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ProgramAndCourse> procProgramAndCourses = await _procedureAdabter
               .Execute<ProgramAndCourse>("[TVET].[proc_Program_And_CourseLoadAll]");
            GetprocProgramAndCourseLoadAllListVm vm = new GetprocProgramAndCourseLoadAllListVm
            {
                procProgramAndCourses = _mapper.Map<IList<ProgramAndCourse>, IList<GetprocProgramAndCourseLoadAllVm>>(procProgramAndCourses)
            };

            return vm;
        }
    }
}
