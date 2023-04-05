using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.UnEmployment.Quiries.procunEmployeeRequest.GetprocunEmployeeRequestLoadAll;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procunEmployeeRequest.GetprocunEmployeeRequestByPrimaryKey
{
    public class GetprocunEmployeeRequestQueryHandler : IRequestHandler<GetprocunEmployeeRequestByPrimaryKey, GetprocunEmployeeRequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocunEmployeeRequestQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocunEmployeeRequestLoadAllListVm> Handle(GetprocunEmployeeRequestByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<unEmployeeRequest> procunEmployeeRequests = await _procedureAdabter
               .Execute<unEmployeeRequest>("[UnEmployment].[proc_unEmployeeRequestLoadByPrimaryKey]", request);
            GetprocunEmployeeRequestLoadAllListVm vm = new GetprocunEmployeeRequestLoadAllListVm
            {
                procunEmployeeRequests = _mapper.Map<IList<unEmployeeRequest>, IList<GetprocunEmployeeRequestLoadAllVm>>(procunEmployeeRequests)
            };

            return vm;
        }
    }
}
