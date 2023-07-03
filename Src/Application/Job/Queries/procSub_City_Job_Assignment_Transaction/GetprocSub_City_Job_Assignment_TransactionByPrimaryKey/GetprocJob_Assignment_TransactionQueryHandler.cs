using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.GetprocSub_City_Job_Assignment_TransactionLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procSub_City_Job_Assignment_Transaction.GetprocSub_City_Job_Assignment_TransactionByPrimaryKey
{
    public class GetprocSub_City_Job_Assignment_TransactionQueryHandler : IRequestHandler<GetprocSub_City_Job_Assignment_TransactionByPrimaryKey, GetprocSub_City_Job_Assignment_TransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSub_City_Job_Assignment_TransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSub_City_Job_Assignment_TransactionLoadAllListVm> Handle(GetprocSub_City_Job_Assignment_TransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Sub_City_Job_Assignment_Transaction> procSub_City_Job_Assignment_Transactions = await _procedureAdabter
               .Execute<Sub_City_Job_Assignment_Transaction>("[Job].[proc_Sub_City_Job_Assignment_TransactionLoadByPrimaryKey]", request);
            GetprocSub_City_Job_Assignment_TransactionLoadAllListVm vm = new GetprocSub_City_Job_Assignment_TransactionLoadAllListVm
            {
                procSub_City_Job_Assignment_Transactions = _mapper.Map<IList<Sub_City_Job_Assignment_Transaction>, IList<GetprocSub_City_Job_Assignment_TransactionLoadAllVm>>(procSub_City_Job_Assignment_Transactions)
            };

            return vm;
        }
    }
}
