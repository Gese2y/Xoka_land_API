using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Quiries.procunEmployeeRequest.GetprocunEmployeeRequestLoadAll
{
    class GetprocunEmployeeRequestLoadAllQueryHandler : IRequestHandler<GetprocunEmployeeRequestLoadAllQuery, GetprocunEmployeeRequestLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocunEmployeeRequestLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocunEmployeeRequestLoadAllListVm> Handle(GetprocunEmployeeRequestLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<unEmployeeRequest> procunEmployeeRequests = await _procedureAdabter
               .Execute<unEmployeeRequest>("[UnEmployment].[proc_unEmployeeRequestLoadAll]");
            GetprocunEmployeeRequestLoadAllListVm vm = new GetprocunEmployeeRequestLoadAllListVm
            {
                procunEmployeeRequests = _mapper.Map<IList<unEmployeeRequest>, IList<GetprocunEmployeeRequestLoadAllVm>>(procunEmployeeRequests)
            };

            return vm;
        }
    }
}
