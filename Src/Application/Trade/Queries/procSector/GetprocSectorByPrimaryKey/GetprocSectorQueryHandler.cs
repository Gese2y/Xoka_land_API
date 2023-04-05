using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procSector.GetprocSectorLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procSector.GetprocSectorByPrimaryKey
{
    public class GetprocSectorQueryHandler : IRequestHandler<GetprocSectorByPrimaryKey, GetprocSectorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocSectorQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocSectorLoadAllListVm> Handle(GetprocSectorByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Sector> procSectors = await _procedureAdabter
               .Execute<Sector>("[dbo].[proc_SectorsLoadByPrimaryKey]", request);
            GetprocSectorLoadAllListVm vm = new GetprocSectorLoadAllListVm
            {
                procSectors = _mapper.Map<IList<Sector>, IList<GetprocSectorLoadAllVm>>(procSectors)
            };

            return vm;
        }
    }
}
