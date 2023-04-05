﻿using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procJob_Assignment_Transaction.GetprocJob_Assignment_TransactionLoadAll
{
    class GetprocJob_Assignment_TransactionLoadAllQueryHandler : IRequestHandler<GetprocJob_Assignment_TransactionLoadAllQuery, GetprocJob_Assignment_TransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJob_Assignment_TransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJob_Assignment_TransactionLoadAllListVm> Handle(GetprocJob_Assignment_TransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Job_Assignment_Transaction> procJob_Assignment_Transactions = await _procedureAdabter
               .Execute<Job_Assignment_Transaction>("[Job].[proc_Job_Assignment_TransactionLoadAll]");
            GetprocJob_Assignment_TransactionLoadAllListVm vm = new GetprocJob_Assignment_TransactionLoadAllListVm
            {
                procJob_Assignment_Transactions = _mapper.Map<IList<Job_Assignment_Transaction>, IList<GetprocJob_Assignment_TransactionLoadAllVm>>(procJob_Assignment_Transactions)
            };

            return vm;
        }
    }
}
