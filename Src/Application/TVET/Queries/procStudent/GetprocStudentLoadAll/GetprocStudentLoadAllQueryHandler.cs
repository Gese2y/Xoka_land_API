using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procStudent.GetprocStudentLoadAll
{
    class GetprocStudentLoadAllQueryHandler : IRequestHandler<GetprocStudentLoadAllQuery, GetprocStudentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocStudentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStudentLoadAllListVm> Handle(GetprocStudentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Student> procStudents = await _procedureAdabter
               .Execute<Student>("[TVET].[proc_StudentLoadAll]");
            GetprocStudentLoadAllListVm vm = new GetprocStudentLoadAllListVm
            {
                procStudents = _mapper.Map<IList<Student>, IList<GetprocStudentLoadAllVm>>(procStudents)
            };

            return vm;
        }
    }
}
