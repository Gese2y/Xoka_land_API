


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.DAR;

namespace Application.DAR.Commands.procdatatypes.procdatatypesInsert.procdatatypesInsertCommand
{

    /// @author  Shimels Alem  proc_data_typesInsert stored procedure.


    public class procdatatypesInsertCommand : IRequest<IList<datatypes_datatypecode>>
    {
        public System.Guid data_type_code { get; set; }
        public int? data_type { get; set; }
        public string data_type_name { get; set; }
    }
		
		
		 
}
 
 