


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procShareHolderOrMSE.procShareHolderOrMSEInsert.procShareHolderOrMSEInsertCommand
{

    /// @author  Shimels Alem  [proc_Share_Holder(MSE)Insert] stored procedure.


    public class procShareHolderOrMSEInsertCommand : IRequest<IList<ShareHolderOrMSE_ID>>
    {
        public System.Guid ID { get; set; }
        public string MSE_TIN { get; set; }
        public string Share_Holder_TIN { get; set; }
        public string MSE_Share_Holder_Status { get; set; }
        public bool? IS_Active { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_Date { get; set; }
    }
		
		
		 
}
 
 