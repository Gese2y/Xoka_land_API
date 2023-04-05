using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procOCACExam.GetprocOCACExamLoadAll
{
    class GetprocOCACExamLoadAllQueryHandler : IRequestHandler<GetprocOCACExamLoadAllQuery, GetprocOCACExamLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOCACExamLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOCACExamLoadAllListVm> Handle(GetprocOCACExamLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OCACExam> procOCACExams = await _procedureAdabter
               .Execute<OCACExam>("[OCAC].[proc_OCAC_ExamLoadAll]");
            GetprocOCACExamLoadAllListVm vm = new GetprocOCACExamLoadAllListVm
            {
                procOCACExams = _mapper.Map<IList<OCACExam>, IList<GetprocOCACExamLoadAllVm>>(procOCACExams)
            };

            return vm;
        }
    }
}
