using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadAll;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Quiries.procCommercialRegistration.GetprocCommercialRegistrationLoadByPrimaryKeyTIN
{
    public class GetprocCommercialRegistrationQueryHandler : IRequestHandler<GetprocCommercialRegistrationLoadByPrimaryKeyTIN, GetprocCommercialRegistrationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCommercialRegistrationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCommercialRegistrationLoadAllListVm> Handle(GetprocCommercialRegistrationLoadByPrimaryKeyTIN request, CancellationToken cancellationToken)
        {
           
            IList<CommercialRegistration> procCommercialRegistrations = await _procedureAdabter
               .Execute<CommercialRegistration>("[Trade].[proc_Commercial_RegistrationLoadByPrimaryKey_TIN]", request);
            GetprocCommercialRegistrationLoadAllListVm vm = new GetprocCommercialRegistrationLoadAllListVm
            {
                procCommercialRegistrations = _mapper.Map<IList<CommercialRegistration>, IList<GetprocCommercialRegistrationLoadAllVm>>(procCommercialRegistrations)
            };

            return vm;
        }
    }
}
