using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procProgramAndCourse.GetprocProgramAndCourseLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procProgramAndCourse.GetprocProgramAndCourseByPrimaryKey
{
    public class GetprocProgramAndCourseQueryHandler : IRequestHandler<GetprocProgramAndCourseByPrimaryKey, GetprocProgramAndCourseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProgramAndCourseQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProgramAndCourseLoadAllListVm> Handle(GetprocProgramAndCourseByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ProgramAndCourse> procProgramAndCourses = await _procedureAdabter
               .Execute<ProgramAndCourse>("[TVET].[proc_Program_And_CourseLoadByPrimaryKey]", request);
            GetprocProgramAndCourseLoadAllListVm vm = new GetprocProgramAndCourseLoadAllListVm
            {
                procProgramAndCourses = _mapper.Map<IList<ProgramAndCourse>, IList<GetprocProgramAndCourseLoadAllVm>>(procProgramAndCourses)
            };

            return vm;
        }
    }
}
