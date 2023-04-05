﻿using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.OCAC.Quiries.procStandardExamReq.GetprocStandardExamReqLoadAll;
using XOKA.Domain.Entities.OCAC;
using XOKA.Domain.Interfaces;

namespace Application.OCAC.Quiries.procStandardExamReq.GetprocStandardExamReqByPrimaryKey
{
    public class GetprocStandardExamReqQueryHandler : IRequestHandler<GetprocStandardExamReqByPrimaryKey, GetprocStandardExamReqLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocStandardExamReqQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStandardExamReqLoadAllListVm> Handle(GetprocStandardExamReqByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<StandardExamReq> procStandardExamReqs = await _procedureAdabter
               .Execute<StandardExamReq>("[OCAC].[proc_Standard_Exam_ReqLoadByPrimaryKey]", request);
            GetprocStandardExamReqLoadAllListVm vm = new GetprocStandardExamReqLoadAllListVm
            {
                procStandardExamReqs = _mapper.Map<IList<StandardExamReq>, IList<GetprocStandardExamReqLoadAllVm>>(procStandardExamReqs)
            };

            return vm;
        }
    }
}
