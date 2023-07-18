﻿using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procApproved_For_Training.GetApproved_For_TrainingLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procApproved_For_Training.GetprocApproved_For_TrainingByPrimaryKey
{
    public class GetprocApproved_For_TrainingQueryHandler : IRequestHandler<GetprocAttendanceByPrimaryKeycommond, GetprocApproved_For_TrainingLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocApproved_For_TrainingQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocApproved_For_TrainingLoadAllListVm> Handle(GetprocAttendanceByPrimaryKeycommond request, CancellationToken cancellationToken)
        {
           
            IList<Approved_For_Training> procApproved = await _procedureAdabter
               .Execute<Approved_For_Training>("[TVET].[proc_Approved_For_TrainingLoadByPrimaryKey]", request);
            GetprocApproved_For_TrainingLoadAllListVm vm = new GetprocApproved_For_TrainingLoadAllListVm
            {
                procApproved = _mapper.Map<IList<Approved_For_Training>, IList<GetprocApproved_For_TrainingLoadAllVm>>(procApproved)
            };

            return vm;
        }
    }
}
