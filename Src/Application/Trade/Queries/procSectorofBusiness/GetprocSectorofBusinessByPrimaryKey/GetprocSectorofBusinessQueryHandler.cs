using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessByPrimaryKey
{
    public class GetprocSectorofBusinessQueryHandler : IRequestHandler<GetprocSectorofBusinessByPrimaryKey, GetprocSectorofBusinessLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSectorofBusinessQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSectorofBusinessLoadAllListVm> Handle(GetprocSectorofBusinessByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<SectorofBusiness> procSectorofBusinesss = await _procedureAdabter
               .Execute<SectorofBusiness>("[Trade].[proc_Sector_of_BusinessLoadByPrimaryKey]", request);
            GetprocSectorofBusinessLoadAllListVm vm = new GetprocSectorofBusinessLoadAllListVm
            {
                procSectorofBusinesss = _mapper.Map<IList<SectorofBusiness>, IList<GetprocSectorofBusinessLoadAllVm>>(procSectorofBusinesss)
            };

            return vm;
        }
    }
}
