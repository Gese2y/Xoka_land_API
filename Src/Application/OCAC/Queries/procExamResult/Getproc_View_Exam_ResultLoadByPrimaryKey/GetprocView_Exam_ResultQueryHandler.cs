using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procView_Exam_Result.GetprocView_Exam_ResultLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procView_Exam_Result.GetprocView_Exam_ResultByPrimaryKey
{
    public class GetprocView_Exam_ResultQueryHandler : IRequestHandler<GetprocView_Exam_ResultByPrimaryKey, GetprocView_Exam_ResultLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocView_Exam_ResultQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocView_Exam_ResultLoadAllListVm> Handle(GetprocView_Exam_ResultByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<View_Exam_Result> procView_Exam_Results = await _procedureAdabter
               .Execute<View_Exam_Result>("[OCAC].[proc_View_Exam_ResultLoadByPrimaryKey_Licence_ID]", request);
            GetprocView_Exam_ResultLoadAllListVm vm = new GetprocView_Exam_ResultLoadAllListVm
            {
                procView_Exam_Results = _mapper.Map<IList<View_Exam_Result>, IList<GetprocView_Exam_ResultLoadAllVm>>(procView_Exam_Results)
            };

            return vm;
        }
    }
}
