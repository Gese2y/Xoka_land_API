using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoLoadAll
{
    class GetprocUnEmployeeInfoLoadQueryHandler : IRequestHandler<GetprocUnEmployeeInfoLoadQuery, GetprocUnEmployeeInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocUnEmployeeInfoLoadQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocUnEmployeeInfoLoadAllListVm> Handle(GetprocUnEmployeeInfoLoadQuery request, CancellationToken cancellationToken)
        {
            IList<UnEmployeeInfo> procUnEmployeeinfo = await _procedureAdabter
               .Execute<UnEmployeeInfo>("[UnEmployment].[proc_UnEmploymentinfoAll]");
            GetprocUnEmployeeInfoLoadAllListVm vm = new GetprocUnEmployeeInfoLoadAllListVm
            {
                procUnEmployeeinfo = _mapper.Map<IList<UnEmployeeInfo>, IList<GetprocUnEmployeeInfoLoadAllVm>>(procUnEmployeeinfo)
            };

            return vm;
        }
    }
}
