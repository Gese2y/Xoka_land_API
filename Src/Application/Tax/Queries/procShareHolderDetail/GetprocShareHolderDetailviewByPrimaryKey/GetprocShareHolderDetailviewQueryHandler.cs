using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailLoadAllview;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procShareHolderDetail.GetprocShareHolderDetailviewByPrimaryKey
{
    public class GetprocShareHolderDetailviewQueryHandler : IRequestHandler<GetprocShareHolderDetailviewByPrimaryKey, GetprocShareHolderDetailLoadAllviewListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocShareHolderDetailviewQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShareHolderDetailLoadAllviewListVm> Handle(GetprocShareHolderDetailviewByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ShareHolderDetailview> procShareHolderDetails = await _procedureAdabter
               .Execute<ShareHolderDetailview>("[Tax].[proc_Share_Holder_DetailLoadviewByPrimaryKey]", request);
            GetprocShareHolderDetailLoadAllviewListVm vm = new GetprocShareHolderDetailLoadAllviewListVm
            {
                procShareHolderDetails = _mapper.Map<IList<ShareHolderDetailview>, IList<GetprocShareHolderDetailLoadAllviewVm>>(procShareHolderDetails)
            };

            return vm;
        }
    }
}
