using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procSectorofBusiness.GetprocSectorofBusinessLoadAll
{
    class GetprocSectorofBusinessLoadAllQueryHandler : IRequestHandler<GetprocSectorofBusinessLoadAllQuery, GetprocSectorofBusinessLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSectorofBusinessLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSectorofBusinessLoadAllListVm> Handle(GetprocSectorofBusinessLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<SectorofBusiness> procSectorofBusinesss = await _procedureAdabter
               .Execute<SectorofBusiness>("[Trade].[proc_Sector_of_BusinessLoadAll]");
            GetprocSectorofBusinessLoadAllListVm vm = new GetprocSectorofBusinessLoadAllListVm
            {
                procSectorofBusinesss = _mapper.Map<IList<SectorofBusiness>, IList<GetprocSectorofBusinessLoadAllVm>>(procSectorofBusinesss)
            };

            return vm;
        }
    }
}
