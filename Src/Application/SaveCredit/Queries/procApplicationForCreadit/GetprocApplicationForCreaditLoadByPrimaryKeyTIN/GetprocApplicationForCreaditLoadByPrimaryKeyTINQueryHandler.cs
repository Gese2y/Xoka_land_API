using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditLoadAll;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Quiries.procApplicationForCreadit.GetprocApplicationForCreaditLoadByPrimaryKeyTIN
{
    public class GetprocApplicationForCreaditQueryHandler : IRequestHandler<GetprocApplicationForCreaditLoadByPrimaryKeyTIN, GetprocApplicationForCreaditLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocApplicationForCreaditQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocApplicationForCreaditLoadAllListVm> Handle(GetprocApplicationForCreaditLoadByPrimaryKeyTIN request, CancellationToken cancellationToken)
        {
           
            IList<ApplicationForCreadit> procApplicationForCreadits = await _procedureAdabter
               .Execute<ApplicationForCreadit>("[SaveCredit].[proc_Application_For_CreaditLoadByPrimaryKey_TIN]", request);
            GetprocApplicationForCreaditLoadAllListVm vm = new GetprocApplicationForCreaditLoadAllListVm
            {
                procApplicationForCreadits = _mapper.Map<IList<ApplicationForCreadit>, IList<GetprocApplicationForCreaditLoadAllVm>>(procApplicationForCreadits)
            };

            return vm;
        }
    }
}
