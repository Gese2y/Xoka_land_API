using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procShareHolderOrMSE.GetprocShareHolderOrMSELoadAll
{
    class GetprocShareHolderOrMSELoadAllQueryHandler : IRequestHandler<GetprocShareHolderOrMSELoadAllQuery, GetprocShareHolderOrMSELoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocShareHolderOrMSELoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShareHolderOrMSELoadAllListVm> Handle(GetprocShareHolderOrMSELoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ShareHolderOrMSE> procShareHolderOrMSEs = await _procedureAdabter
               .Execute<ShareHolderOrMSE>("[Tax].[proc_Share_Holder(MSE)LoadAll]");
            GetprocShareHolderOrMSELoadAllListVm vm = new GetprocShareHolderOrMSELoadAllListVm
            {
                procShareHolderOrMSEs = _mapper.Map<IList<ShareHolderOrMSE>, IList<GetprocShareHolderOrMSELoadAllVm>>(procShareHolderOrMSEs)
            };

            return vm;
        }
    }
}
