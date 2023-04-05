


using MediatR;
using System;
using System.Collections.Generic;

namespace Application.Compress.Commands.Compress.CompressInsert.CompressInsertCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
     
        public class CompressInsertCommand : IRequest
    {
		public byte[] base64Data { get; set; }
	}
		
		
		 
}
 
 