


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procPayment.procPaymentInsert.procPaymentInsertCommand
{

	/// @author  Shimels Alem  proc_AssetsInsert stored procedure.


	public class procPaymentInsertCommand : IRequest<IList<PaymentID>>
	{
        public System.Guid PID { get; set; }
        public Nullable<System.Guid> Work_Space_ID { get; set; }
        public string TIN { get; set; }
        public string Application_No { get; set; }
        public System.Guid Service_ID { get; set; }
        public decimal Amount { get; set; }
        public Nullable<bool> Process_Invoice { get; set; }
        public Nullable<bool> Printed { get; set; }
        public string Description { get; set; }
        public DateTime? Date_Paid { get; set; }
        public string Invoice_No { get; set; }
        public System.Guid SDP_ID { get; set; }
        public Nullable<System.Guid> Created_By { get; set; }
        public Nullable<System.Guid> Updated_By { get; set; }
        public Nullable<System.Guid> Deleted_By { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<System.DateTime> Deleted_Date { get; set; }
        public string Method { get; set; }
        public Nullable<decimal> Service_Fee { get; set; }

    }
		
		
		 
}
 
 