using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailLoadAll
{
    class GetprocShareHolderDetailLoadAllQueryHandler : IRequestHandler<GetprocShareHolderDetailLoadAllQuery, GetprocShareHolderDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocShareHolderDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShareHolderDetailLoadAllListVm> Handle(GetprocShareHolderDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ShareHolderDetail> procShareHolderDetails = await _procedureAdabter
               .Execute<ShareHolderDetail>("[Tax].[proc_Share_Holder_DetailLoadAll]");
            GetprocShareHolderDetailLoadAllListVm vm = new GetprocShareHolderDetailLoadAllListVm
            {
                procShareHolderDetails = _mapper.Map<IList<ShareHolderDetail>, IList<GetprocShareHolderDetailLoadAllVm>>(procShareHolderDetails)
            };

            return vm;
        }
    }
}
