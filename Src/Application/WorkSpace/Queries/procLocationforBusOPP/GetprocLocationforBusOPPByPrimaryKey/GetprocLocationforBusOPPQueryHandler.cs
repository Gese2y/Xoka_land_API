using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.WorkSpace.Quiries.procLocationforBusOPP.GetprocLocationforBusOPPLoadAll;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procLocationforBusOPP.GetprocLocationforBusOPPByPrimaryKey
{
    public class GetprocLocationforBusOPPQueryHandler : IRequestHandler<GetprocLocationforBusOPPByPrimaryKey, GetprocLocationforBusOPPLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLocationforBusOPPQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLocationforBusOPPLoadAllListVm> Handle(GetprocLocationforBusOPPByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LocationforBusOPP> procLocationforBusOPPs = await _procedureAdabter
               .Execute<LocationforBusOPP>("[WorkSpace].[proc_Location_for_Bus_OPPLoadByPrimaryKey]", request);
            GetprocLocationforBusOPPLoadAllListVm vm = new GetprocLocationforBusOPPLoadAllListVm
            {
                procLocationforBusOPPs = _mapper.Map<IList<LocationforBusOPP>, IList<GetprocLocationforBusOPPLoadAllVm>>(procLocationforBusOPPs)
            };

            return vm;
        }
    }
}
