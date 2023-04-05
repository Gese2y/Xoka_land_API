


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procTVETResult.procTVETResultInsert.procTVETResultInsertCommand
{

    /// @author  Shimels Alem  proc_TVET_ResultInsert stored procedure.


    public class procTVETResultInsertCommand : IRequest<IList<TVETResult_RId>>
    {
        public System.Guid RId { get; set; }
        public System.Guid? EID { get; set; }
        public System.Guid? Student_ID { get; set; }
        public string Total_Result { get; set; }
        public string Remark { get; set; }
        public bool? IsPass { get; set; }
    }
		
		
		 
}
 
 