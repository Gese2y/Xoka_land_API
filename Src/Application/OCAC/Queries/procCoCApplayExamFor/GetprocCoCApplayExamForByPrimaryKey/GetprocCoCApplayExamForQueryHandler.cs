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

namespace Application.OCAC.Quiries.procCoCApplayExamFor.GetprocCoCApplayExamForByPrimaryKey
{
    public class GetprocCoCApplayExamForQueryHandler : IRequestHandler<GetprocCoCApplayExamForByPrimaryKey, GetprocCoCApplayExamForLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCoCApplayExamForQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCoCApplayExamForLoadAllListVm> Handle(GetprocCoCApplayExamForByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CoCApplayExamFor> procCoCApplayExamFors = await _procedureAdabter
               .Execute<CoCApplayExamFor>("[OCAC].[proc_CoCApplay_Exam_ForLoadByPrimaryKey]", request);
            GetprocCoCApplayExamForLoadAllListVm vm = new GetprocCoCApplayExamForLoadAllListVm
            {
                procCoCApplayExamFors = _mapper.Map<IList<CoCApplayExamFor>, IList<GetprocCoCApplayExamForLoadAllVm>>(procCoCApplayExamFors)
            };

            return vm;
        }
    }
}
