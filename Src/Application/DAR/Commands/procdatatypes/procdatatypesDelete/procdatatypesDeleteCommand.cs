 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.DAR;

namespace Application.DAR.Commands.procdatatypes.procdatatypesDelete.procdatatypesDeleteCommand
{

    // @author  Shimels Alem  proc_data_typesDelete stored procedure.

    public class procdatatypesDeleteCommand : IRequest<IList<datatypes_datatypecode>>
    {
        public System.Guid data_type_code { get; set; }
    }
		
     
		
		 
}
 
 