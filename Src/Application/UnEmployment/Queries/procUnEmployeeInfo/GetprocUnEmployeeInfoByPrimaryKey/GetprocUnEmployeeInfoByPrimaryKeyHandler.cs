using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoLoadAll;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procUnEmployeeInfo.GetprocUnEmployeeInfoByPrimaryKey
{
    public class GetprocUnEmployeeInfoByPrimaryKeyHandler : IRequestHandler<GetprocUnEmployeeInfoByPrimaryKey, GetprocUnEmployeeInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocUnEmployeeInfoByPrimaryKeyHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocUnEmployeeInfoLoadAllListVm> Handle(GetprocUnEmployeeInfoByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<UnEmployeeInfo> procUnEmployeeinfo = await _procedureAdabter
               .Execute<UnEmployeeInfo>("[UnEmployment].[proc_UnEmploymentByKebeleId]", request);
            GetprocUnEmployeeInfoLoadAllListVm vm = new GetprocUnEmployeeInfoLoadAllListVm
            {
                procUnEmployeeinfo = _mapper.Map<IList<UnEmployeeInfo>, IList<GetprocUnEmployeeInfoLoadAllVm>>(procUnEmployeeinfo)
            };

            return vm;
        }
    }
}
