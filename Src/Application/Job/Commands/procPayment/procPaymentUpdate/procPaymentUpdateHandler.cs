

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procPayment.procPaymentUpdate.procPaymentUpdateCommand
{

    /// @author  Shimels Alem  proc_AssetsUpdate stored procedure.


    public class procPaymentUpdateHandler : IRequestHandler<procPaymentUpdateCommand, IList<PaymentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPaymentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaymentID>> Handle(procPaymentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PaymentID> result = await _procedureAdabter
                .Execute<PaymentID>("[dbo].proc_PaymentUpdate", request);
           

            return result;
        }
    }
}
 