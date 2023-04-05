using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procListofCourse.GetprocListofCourseLoadAll
{
    class GetprocListofCourseLoadAllQueryHandler : IRequestHandler<GetprocListofCourseLoadAllQuery, GetprocListofCourseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocListofCourseLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocListofCourseLoadAllListVm> Handle(GetprocListofCourseLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ListofCourse> procListofCourses = await _procedureAdabter
               .Execute<ListofCourse>("[TVET].[proc_List_of_CourseLoadAll]");
            GetprocListofCourseLoadAllListVm vm = new GetprocListofCourseLoadAllListVm
            {
                procListofCourses = _mapper.Map<IList<ListofCourse>, IList<GetprocListofCourseLoadAllVm>>(procListofCourses)
            };

            return vm;
        }
    }
}
