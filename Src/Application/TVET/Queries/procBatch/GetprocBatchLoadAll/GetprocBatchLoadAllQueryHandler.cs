using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procBatch.GetprocBatchLoadAll
{
    class GetprocBatchLoadAllQueryHandler : IRequestHandler<GetprocBatchLoadAllQuery, GetprocBatchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocBatchLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBatchLoadAllListVm> Handle(GetprocBatchLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Batch> procBatchs = await _procedureAdabter
               .Execute<Batch>("[TVET].[proc_BatchLoadAll]");
            GetprocBatchLoadAllListVm vm = new GetprocBatchLoadAllListVm
            {
                procBatchs = _mapper.Map<IList<Batch>, IList<GetprocBatchLoadAllVm>>(procBatchs)
            };

            return vm;
        }
    }
}
