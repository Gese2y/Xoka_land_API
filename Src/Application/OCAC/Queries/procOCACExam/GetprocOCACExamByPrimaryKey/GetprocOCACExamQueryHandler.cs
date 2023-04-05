using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procOCACExam.GetprocOCACExamLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procOCACExam.GetprocOCACExamByPrimaryKey
{
    public class GetprocOCACExamQueryHandler : IRequestHandler<GetprocOCACExamByPrimaryKey, GetprocOCACExamLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOCACExamQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOCACExamLoadAllListVm> Handle(GetprocOCACExamByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<OCACExam> procOCACExams = await _procedureAdabter
               .Execute<OCACExam>("[OCAC].[proc_OCAC_ExamLoadByPrimaryKey]", request);
            GetprocOCACExamLoadAllListVm vm = new GetprocOCACExamLoadAllListVm
            {
                procOCACExams = _mapper.Map<IList<OCACExam>, IList<GetprocOCACExamLoadAllVm>>(procOCACExams)
            };

            return vm;
        }
    }
}
