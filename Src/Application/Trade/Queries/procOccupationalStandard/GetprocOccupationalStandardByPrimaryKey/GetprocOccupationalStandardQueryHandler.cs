using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procOccupationalStandard.GetprocOccupationalStandardLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procOccupationalStandard.GetprocOccupationalStandardByPrimaryKey
{
    public class GetprocOccupationalStandardQueryHandler : IRequestHandler<GetprocOccupationalStandardByPrimaryKey, GetprocOccupationalStandardLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOccupationalStandardQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOccupationalStandardLoadAllListVm> Handle(GetprocOccupationalStandardByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<OccupationalStandard> procOccupationalStandards = await _procedureAdabter
               .Execute<OccupationalStandard>("[Trade].[proc_Occupational_StandardLoadByPrimaryKey]", request);
            GetprocOccupationalStandardLoadAllListVm vm = new GetprocOccupationalStandardLoadAllListVm
            {
                procOccupationalStandards = _mapper.Map<IList<OccupationalStandard>, IList<GetprocOccupationalStandardLoadAllVm>>(procOccupationalStandards)
            };

            return vm;
        }
    }
}
