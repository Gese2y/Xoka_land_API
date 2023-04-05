using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Commands.procdatatypes.procdatatypesUpdate.procdatatypesUpdateCommand
{

    /// @author  Shimels Alem  proc_data_typesUpdate stored procedure.

    public class procdatatypesUpdateCommand : IRequest<IList<datatypes_datatypecode>>
   {
        public System.Guid data_type_code { get; set; }
        public int? data_type { get; set; }
        public string data_type_name { get; set; }
   }
		
		
		 
}

