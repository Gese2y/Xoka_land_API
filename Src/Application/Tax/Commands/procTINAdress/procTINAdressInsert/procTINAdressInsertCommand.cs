


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procTINAdress.procTINAdressInsert.procTINAdressInsertCommand
{

    /// @author  Shimels Alem  proc_TIN_AdressInsert stored procedure.


    public class procTINAdressInsertCommand : IRequest<IList<TINAdress_ID>>
    {
        public System.Guid ID { get; set; }
        public string TIN { get; set; }
        public System.Guid Region { get; set; }
        public System.Guid Zone { get; set; }
        public System.Guid Woreda { get; set; }
        public string kebele { get; set; }
        public string House_Number { get; set; }
        public bool? IS_Active { get; set; }
        public System.Guid? Parent { get; set; }
    }
		
		
		 
}
 
 