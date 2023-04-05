using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procOccupationalStandard.GetprocOccupationalStandardLoadAll
{
    class GetprocOccupationalStandardLoadAllQueryHandler : IRequestHandler<GetprocOccupationalStandardLoadAllQuery, GetprocOccupationalStandardLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOccupationalStandardLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOccupationalStandardLoadAllListVm> Handle(GetprocOccupationalStandardLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OccupationalStandard> procOccupationalStandards = await _procedureAdabter
               .Execute<OccupationalStandard>("[Trade].[proc_Occupational_StandardLoadAll]");
            GetprocOccupationalStandardLoadAllListVm vm = new GetprocOccupationalStandardLoadAllListVm
            {
                procOccupationalStandards = _mapper.Map<IList<OccupationalStandard>, IList<GetprocOccupationalStandardLoadAllVm>>(procOccupationalStandards)
            };

            return vm;
        }
    }
}
