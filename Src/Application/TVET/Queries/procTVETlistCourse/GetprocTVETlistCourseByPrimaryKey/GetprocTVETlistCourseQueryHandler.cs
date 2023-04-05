using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procTVETlistCourse.GetprocTVETlistCourseLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procTVETlistCourse.GetprocTVETlistCourseByPrimaryKey
{
    public class GetprocTVETlistCourseQueryHandler : IRequestHandler<GetprocTVETlistCourseByPrimaryKey, GetprocTVETlistCourseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocTVETlistCourseQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocTVETlistCourseLoadAllListVm> Handle(GetprocTVETlistCourseByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<TVETlistCourse> procTVETlistCourses = await _procedureAdabter
               .Execute<TVETlistCourse>("[TVET].[proc_TVET_list_CourseLoadByPrimaryKey]", request);
            GetprocTVETlistCourseLoadAllListVm vm = new GetprocTVETlistCourseLoadAllListVm
            {
                procTVETlistCourses = _mapper.Map<IList<TVETlistCourse>, IList<GetprocTVETlistCourseLoadAllVm>>(procTVETlistCourses)
            };

            return vm;
        }
    }
}
