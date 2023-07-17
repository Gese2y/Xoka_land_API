using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction.JobMatchwhenitPicktransactionLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction.JobMatchwhenitPicktransactionByPrimaryKey
{
    public class GetprocJobMatchwhenitPicktransactionQueryHandler : IRequestHandler<JobMatchwhenitPicktransactionByPrimaryKey, JobMatchwhenitPicktransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJobMatchwhenitPicktransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<JobMatchwhenitPicktransactionLoadAllListVm> Handle(JobMatchwhenitPicktransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<getJobMatchwhenitPicktransaction> procMatch = await _procedureAdabter
               .Execute<getJobMatchwhenitPicktransaction>("[dbo].[getJobMatchwhenitPicktransaction]", request);
            JobMatchwhenitPicktransactionLoadAllListVm vm = new JobMatchwhenitPicktransactionLoadAllListVm
            {
                procMatch = _mapper.Map<IList<getJobMatchwhenitPicktransaction>, IList<JobMatchwhenitPicktransactionLoadAllVm>>(procMatch)
            };

            return vm;
        }
    }
}
