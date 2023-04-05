using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeLoadAll;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procUnEmployee.GetprocUnEmployeeByPrimaryKey
{
    public class GetprocUnEmployeeQueryHandler : IRequestHandler<GetprocUnEmployeeByPrimaryKey, GetprocUnEmployeeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocUnEmployeeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocUnEmployeeLoadAllListVm> Handle(GetprocUnEmployeeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<UnEmployee> procUnEmployees = await _procedureAdabter
               .Execute<UnEmployee>("[UnEmployment].[proc_UnEmployeeLoadByPrimaryKey]", request);
            GetprocUnEmployeeLoadAllListVm vm = new GetprocUnEmployeeLoadAllListVm
            {
                procUnEmployees = _mapper.Map<IList<UnEmployee>, IList<GetprocUnEmployeeLoadAllVm>>(procUnEmployees)
            };

            return vm;
        }
    }
}
