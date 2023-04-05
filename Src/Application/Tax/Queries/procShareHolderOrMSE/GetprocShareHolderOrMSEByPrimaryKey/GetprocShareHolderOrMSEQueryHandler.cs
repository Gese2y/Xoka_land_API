using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procShareHolderOrMSE.GetprocShareHolderOrMSELoadAll;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procShareHolderOrMSE.GetprocShareHolderOrMSEByPrimaryKey
{
    public class GetprocShareHolderOrMSEQueryHandler : IRequestHandler<GetprocShareHolderOrMSEByPrimaryKey, GetprocShareHolderOrMSELoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocShareHolderOrMSEQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocShareHolderOrMSELoadAllListVm> Handle(GetprocShareHolderOrMSEByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ShareHolderOrMSE> procShareHolderOrMSEs = await _procedureAdabter
               .Execute<ShareHolderOrMSE>("[Tax].[proc_Share_Holder(MSE)LoadByPrimaryKey]", request);
            GetprocShareHolderOrMSELoadAllListVm vm = new GetprocShareHolderOrMSELoadAllListVm
            {
                procShareHolderOrMSEs = _mapper.Map<IList<ShareHolderOrMSE>, IList<GetprocShareHolderOrMSELoadAllVm>>(procShareHolderOrMSEs)
            };

            return vm;
        }
    }
}
