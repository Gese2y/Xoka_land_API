using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procPayment.GetprocPaymentLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procPayment.GetprocPaymentByPrimaryKey
{
    public class GetprocPaymentQueryHandler : IRequestHandler<GetprocPaymentByPrimaryKey, GetprocPaymentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPaymentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPaymentLoadAllListVm> Handle(GetprocPaymentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Payment> procPayments = await _procedureAdabter
               .Execute<Payment>("[dbo].[proc_PaymentByPrimaryKey]", request);
            GetprocPaymentLoadAllListVm vm = new GetprocPaymentLoadAllListVm
            {
                procPayments = _mapper.Map<IList<Payment>, IList<GetprocPaymentLoadAllVm>>(procPayments)
            };

            return vm;
        }
    }
}
