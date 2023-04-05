 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procPayment.procPaymentDelete.procPaymentDeleteCommand
{

    // @author  Shimels Alem  proc_AssetsDelete stored procedure.

    public class procPaymentDeleteCommand : IRequest<IList<PaymentID>>
    {

        public System.Guid PID { get; set; }
    }
		
     
		
		 
}
 
 