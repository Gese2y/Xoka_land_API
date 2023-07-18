using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.ProcgetJobMatchwhenitPicktransaction.JobMatchwhenitPicktransactionLoadAll
{
    class GetLoadAllQueryHandler : IRequestHandler<GetJobMatchwhenitPicktransactionLoadAllQuery, JobMatchwhenitPicktransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<JobMatchwhenitPicktransactionLoadAllListVm> Handle(GetJobMatchwhenitPicktransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<getJobMatchwhenitPicktransaction> procMatch = await _procedureAdabter
               .Execute<getJobMatchwhenitPicktransaction>("[Job].[proc_AssetsLoadAll]");
            JobMatchwhenitPicktransactionLoadAllListVm vm = new JobMatchwhenitPicktransactionLoadAllListVm
            {
                procMatch = _mapper.Map<IList<getJobMatchwhenitPicktransaction>, IList<JobMatchwhenitPicktransactionLoadAllVm>>(procMatch)
            };

            return vm;
        }
    }
}
