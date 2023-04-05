


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Trade;

namespace Application.Trade.Commands.procCommercialRegistration.procCommercialRegistrationInsert.procCommercialRegistrationInsertCommand
{

    /// @author  Shimels Alem  proc_Commercial_RegistrationInsert stored procedure.


    public class procCommercialRegistrationInsertCommand : IRequest<IList<CommercialRegistration_COMREGNumber>>
    {
        public string COM_REG_Number { get; set; }
        public string TIN { get; set; }
        public System.Guid? Temp_Name_ID { get; set; }
        public string Rgistration__Name_AM { get; set; }
        public string Rgistration__Name_EN { get; set; }
        public System.DateTime? Rgistration_Date_EN { get; set; }
        public System.DateTime? Rgistration_Date_AM { get; set; }
        public bool? IS_GM { get; set; }
        public System.DateTime? modified_Date { get; set; }
    }
		
		
		 
}
 
 