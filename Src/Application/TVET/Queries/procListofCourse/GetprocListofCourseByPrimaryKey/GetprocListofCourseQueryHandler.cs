using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procListofCourse.GetprocListofCourseLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procListofCourse.GetprocListofCourseByPrimaryKey
{
    public class GetprocListofCourseQueryHandler : IRequestHandler<GetprocListofCourseByPrimaryKey, GetprocListofCourseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocListofCourseQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocListofCourseLoadAllListVm> Handle(GetprocListofCourseByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ListofCourse> procListofCourses = await _procedureAdabter
               .Execute<ListofCourse>("[TVET].[proc_List_of_CourseLoadByPrimaryKey]", request);
            GetprocListofCourseLoadAllListVm vm = new GetprocListofCourseLoadAllListVm
            {
                procListofCourses = _mapper.Map<IList<ListofCourse>, IList<GetprocListofCourseLoadAllVm>>(procListofCourses)
            };

            return vm;
        }
    }
}
