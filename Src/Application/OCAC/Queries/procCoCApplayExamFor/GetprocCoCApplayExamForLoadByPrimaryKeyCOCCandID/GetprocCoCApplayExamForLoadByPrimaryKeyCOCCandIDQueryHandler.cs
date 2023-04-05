using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID
{
    public class GetprocCoCApplayExamForQueryHandler : IRequestHandler<GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID, GetprocCoCApplayExamForLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCoCApplayExamForQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCoCApplayExamForLoadAllListVm> Handle(GetprocCoCApplayExamForLoadByPrimaryKeyCOCCandID request, CancellationToken cancellationToken)
        {
           
            IList<CoCApplayExamFor> procCoCApplayExamFors = await _procedureAdabter
               .Execute<CoCApplayExamFor>("[OCAC].[proc_CoCApplay_Exam_ForLoadByPrimaryKey_COC_Cand_ID]", request);
            GetprocCoCApplayExamForLoadAllListVm vm = new GetprocCoCApplayExamForLoadAllListVm
            {
                procCoCApplayExamFors = _mapper.Map<IList<CoCApplayExamFor>, IList<GetprocCoCApplayExamForLoadAllVm>>(procCoCApplayExamFors)
            };

            return vm;
        }
    }
}
