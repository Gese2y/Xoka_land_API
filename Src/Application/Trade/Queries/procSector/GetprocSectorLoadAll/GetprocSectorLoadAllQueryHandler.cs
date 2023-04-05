using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procSector.GetprocSectorLoadAll
{
    class GetprocSectorLoadAllQueryHandler : IRequestHandler<GetprocSectorLoadAllQuery, GetprocSectorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocSectorLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSectorLoadAllListVm> Handle(GetprocSectorLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Sector> procSectors = await _procedureAdabter
               .Execute<Sector>("[dbo].[proc_SectorsLoadAll]");
            GetprocSectorLoadAllListVm vm = new GetprocSectorLoadAllListVm
            {
                procSectors = _mapper.Map<IList<Sector>, IList<GetprocSectorLoadAllVm>>(procSectors)
            };

            return vm;
        }
    }
}
