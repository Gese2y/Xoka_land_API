using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Job.Quiries.procMSEBalanceSheet.GetprocMSEBalanceSheetLoadAll;

namespace Application.Job.Quiries.procMSEBalanceSheet.GetprocMSEBalanceSheetByPrimaryKey
{
    /// @author  Shimels Alem proc_MSE_Balance_SheetLoadByPrimaryKey stored procedure.

    public class GetprocMSEBalanceSheetByPrimaryKey : IRequest<GetprocMSEBalanceSheetLoadAllListVm>
    {
        public int Year { get; set; }
        public string TIN { get; set; }
    }
}
