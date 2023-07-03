using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.GetprocSub_City_Job_Assignment_TransactionLoadAll
{
    class GetprocSub_City_Job_Assignment_TransactionLoadAllQueryHandler : IRequestHandler<GetprocSub_City_Job_Assignment_TransactionLoadAllQuery, GetprocSub_City_Job_Assignment_TransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSub_City_Job_Assignment_TransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSub_City_Job_Assignment_TransactionLoadAllListVm> Handle(GetprocSub_City_Job_Assignment_TransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Sub_City_Job_Assignment_Transaction> procSub_City_Job_Assignment_Transactions = await _procedureAdabter
               .Execute<Sub_City_Job_Assignment_Transaction>("[Job].[proc_Sub_City_Job_Assignment_TransactionLoadAll]");
            GetprocSub_City_Job_Assignment_TransactionLoadAllListVm vm = new GetprocSub_City_Job_Assignment_TransactionLoadAllListVm
            {
                procSub_City_Job_Assignment_Transactions = _mapper.Map<IList<Sub_City_Job_Assignment_Transaction>, IList<GetprocSub_City_Job_Assignment_TransactionLoadAllVm>>(procSub_City_Job_Assignment_Transactions)
            };

            return vm;
        }
    }
}
