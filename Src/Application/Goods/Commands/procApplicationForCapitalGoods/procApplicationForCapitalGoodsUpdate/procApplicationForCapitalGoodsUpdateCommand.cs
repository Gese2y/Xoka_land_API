using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Goods;
using XOKA.Domain.Interfaces;

namespace Application.Goods.Commands.procApplicationForCapitalGoods.procApplicationForCapitalGoodsUpdate.procApplicationForCapitalGoodsUpdateCommand
{

    /// @author  Shimels Alem  proc_Application_For_Capital_GoodsUpdate stored procedure.

    public class procApplicationForCapitalGoodsUpdateCommand : IRequest<IList<ApplicationForCapitalGoods_ID>>
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

