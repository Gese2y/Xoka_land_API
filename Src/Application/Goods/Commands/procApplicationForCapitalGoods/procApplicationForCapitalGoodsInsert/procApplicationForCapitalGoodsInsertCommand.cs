


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Goods;

namespace Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsInsert.procApplicationForCapitalGoodsInsertCommand
{

    /// @author  Shimels Alem  proc_Application_For_Capital_GoodsInsert stored procedure.


    public class procApplicationForCapitalGoodsInsertCommand : IRequest<IList<ApplicationForCapitalGoods_ID>>
    {
        public System.Guid ID { get; set; }
        public System.Guid? Licence_Id { get; set; }
        public long? TIN { get; set; }
        public string Application { get; set; }
        public System.Double? Amount { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Disprove { get; set; }
    }
		
		
		 
}
 
 