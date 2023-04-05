using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procStudent.GetprocStudentLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procStudent.GetprocStudentByPrimaryKey
{
    public class GetprocStudentQueryHandler : IRequestHandler<GetprocStudentByPrimaryKey, GetprocStudentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocStudentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStudentLoadAllListVm> Handle(GetprocStudentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Student> procStudents = await _procedureAdabter
               .Execute<Student>("[TVET].[proc_StudentLoadByPrimaryKey]", request);
            GetprocStudentLoadAllListVm vm = new GetprocStudentLoadAllListVm
            {
                procStudents = _mapper.Map<IList<Student>, IList<GetprocStudentLoadAllVm>>(procStudents)
            };

            return vm;
        }
    }
}
