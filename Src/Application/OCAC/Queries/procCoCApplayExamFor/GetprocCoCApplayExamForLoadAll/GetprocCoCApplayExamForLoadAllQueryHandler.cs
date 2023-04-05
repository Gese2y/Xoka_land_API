using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadAll
{
    class GetprocCoCApplayExamForLoadAllQueryHandler : IRequestHandler<GetprocCoCApplayExamForLoadAllQuery, GetprocCoCApplayExamForLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCoCApplayExamForLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCoCApplayExamForLoadAllListVm> Handle(GetprocCoCApplayExamForLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CoCApplayExamFor> procCoCApplayExamFors = await _procedureAdabter
               .Execute<CoCApplayExamFor>("[OCAC].[proc_CoCApplay_Exam_ForLoadAll]");
            GetprocCoCApplayExamForLoadAllListVm vm = new GetprocCoCApplayExamForLoadAllListVm
            {
                procCoCApplayExamFors = _mapper.Map<IList<CoCApplayExamFor>, IList<GetprocCoCApplayExamForLoadAllVm>>(procCoCApplayExamFors)
            };

            return vm;
        }
    }
}
