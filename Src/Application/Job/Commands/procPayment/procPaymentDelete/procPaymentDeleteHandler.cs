using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procPayment.procPaymentDelete.procPaymentDeleteCommand
{

    /// @author  Shimels Alem  proc_AssetsDelete stored procedure.


    public class procPaymentDeleteHandler : IRequestHandler<procPaymentDeleteCommand, IList<PaymentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPaymentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaymentID>> Handle(procPaymentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PaymentID> result = await _procedureAdabter
                .Execute<PaymentID>("[dbo].proc_PaymentDelete", request);
           

            return result;
        }
    }
}
  