using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailLoadAll;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailByPrimaryKey
{
    public class GetprocShareHolderDetailQueryHandler : IRequestHandler<GetprocShareHolderDetailByPrimaryKey, GetprocShareHolderDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocShareHolderDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShareHolderDetailLoadAllListVm> Handle(GetprocShareHolderDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ShareHolderDetail> procShareHolderDetails = await _procedureAdabter
               .Execute<ShareHolderDetail>("[Tax].[proc_Share_Holder_DetailLoadByPrimaryKey]", request);
            GetprocShareHolderDetailLoadAllListVm vm = new GetprocShareHolderDetailLoadAllListVm
            {
                procShareHolderDetails = _mapper.Map<IList<ShareHolderDetail>, IList<GetprocShareHolderDetailLoadAllVm>>(procShareHolderDetails)
            };

            return vm;
        }
    }
}
