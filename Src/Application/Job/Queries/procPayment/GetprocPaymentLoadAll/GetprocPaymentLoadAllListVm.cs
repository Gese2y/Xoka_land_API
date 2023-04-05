using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Job.Quiries.procPayment.GetprocPaymentLoadAll
{
    /// @author  Shimels Alem  proc_AssetsLoadAll stored procedure.

    public class GetprocPaymentLoadAllListVm
    {
        public IList<GetprocPaymentLoadAllVm> procPayments { get; set; }
    }
}
