 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMSEBalanceSheet.procMSEBalanceSheetDelete.procMSEBalanceSheetDeleteCommand
{

    // @author  Shimels Alem  proc_MSE_Balance_SheetDelete stored procedure.

    public class procMSEBalanceSheetDeleteCommand : IRequest<IList<MSEBalanceSheet_YearAndTIN>>
    {
        public int Year { get; set; }
        public string TIN { get; set; }
    }
		
     
		
		 
}
 
 