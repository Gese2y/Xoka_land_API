﻿


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procBatch.procBatchInsert.procBatchInsertCommand
{

    /// @author  Shimels Alem  proc_BatchInsert stored procedure.


    public class procBatchInsertCommand : IRequest<IList<Batch_Code>>
    {
        public string Code { get; set; }
        public string provider_Code { get; set; }
        public string Program_Code { get; set; }
        public int Year { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
        public bool? is_Active { get; set; }
    }
		
		
		 
}
 
 