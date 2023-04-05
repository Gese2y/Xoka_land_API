using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procPayment.GetprocPaymentLoadAll
{
    class GetprocPaymentLoadAllQueryHandler : IRequestHandler<GetprocPaymentLoadAllQuery, GetprocPaymentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocPaymentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPaymentLoadAllListVm> Handle(GetprocPaymentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Payment> procPayments = await _procedureAdabter
               .Execute<Payment>("[dbo].[proc_PaymentLoadAll]");
            GetprocPaymentLoadAllListVm vm = new GetprocPaymentLoadAllListVm
            {
                procPayments = _mapper.Map<IList<Payment>, IList<GetprocPaymentLoadAllVm>>(procPayments)
            };

            return vm;
        }
    }
}
