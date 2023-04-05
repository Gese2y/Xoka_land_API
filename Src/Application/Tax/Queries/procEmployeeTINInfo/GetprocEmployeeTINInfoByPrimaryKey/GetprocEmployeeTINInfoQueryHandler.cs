using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Tax.Quiries.procEmployeeTINInfo.GetprocEmployeeTINInfoLoadAll;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Quiries.procEmployeeTINInfo.GetprocEmployeeTINInfoByPrimaryKey
{
    public class GetprocEmployeeTINInfoQueryHandler : IRequestHandler<GetprocEmployeeTINInfoByPrimaryKey, GetprocEmployeeTINInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEmployeeTINInfoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmployeeTINInfoLoadAllListVm> Handle(GetprocEmployeeTINInfoByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EmployeeTINInfo> procEmployeeTINInfos = await _procedureAdabter
               .Execute<EmployeeTINInfo>("[Tax].[proc_Employee_TIN_InfoLoadByPrimaryKey]", request);
            GetprocEmployeeTINInfoLoadAllListVm vm = new GetprocEmployeeTINInfoLoadAllListVm
            {
                procEmployeeTINInfos = _mapper.Map<IList<EmployeeTINInfo>, IList<GetprocEmployeeTINInfoLoadAllVm>>(procEmployeeTINInfos)
            };

            return vm;
        }
    }
}
