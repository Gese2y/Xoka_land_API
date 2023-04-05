using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.TVET.Quiries.procBatch.GetprocBatchLoadAll;
using XOKA.Domain.Entities.TVET;
using XOKA.Domain.Interfaces;

namespace Application.TVET.Quiries.procBatch.GetprocBatchByPrimaryKey
{
    public class GetprocBatchQueryHandler : IRequestHandler<GetprocBatchByPrimaryKey, GetprocBatchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBatchQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBatchLoadAllListVm> Handle(GetprocBatchByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Batch> procBatchs = await _procedureAdabter
               .Execute<Batch>("[TVET].[proc_BatchLoadByPrimaryKey]", request);
            GetprocBatchLoadAllListVm vm = new GetprocBatchLoadAllListVm
            {
                procBatchs = _mapper.Map<IList<Batch>, IList<GetprocBatchLoadAllVm>>(procBatchs)
            };

            return vm;
        }
    }
}
