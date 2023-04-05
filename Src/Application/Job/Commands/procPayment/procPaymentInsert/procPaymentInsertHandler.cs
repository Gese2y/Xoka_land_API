



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procPayment.procPaymentInsert.procPaymentInsertCommand
{

    /// @author  Shimels Alem  proc_PaymentInsert stored procedure.


    public class procPaymentInsertHandler : IRequestHandler<procPaymentInsertCommand, IList<PaymentID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPaymentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaymentID>> Handle(procPaymentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PaymentID> result = await _procedureAdabter
                .Execute<PaymentID>("[dbo].proc_PaymentInsert", request);
           

            return result;
        }
    }
}
 