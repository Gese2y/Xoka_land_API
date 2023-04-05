using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Commands.procDAR.procDARUpdate.procDARUpdateCommand
{

	/// @author  Shimels Alem  proc_DARUpdate stored procedure.

	public class procDARUpdateCommand : IRequest<IList<DAR_DARNO>>
   {
        public string DAR_NO { get; set; }
        public string Name_EN { get; set; }
        public string Name_AM { get; set; }
        public string DAR_Type { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public bool? IS_Signed { get; set; }
        public System.Int32? No_of_Copy { get; set; }
        public string Parent { get; set; }
        public System.Guid? Licence_Id { get; set; }
        public string Remark { get; set; }
        public System.Guid? Temp_Name_ID { get; set; }
        public string Ownership_Type { get; set; }
        public byte[] Scanned_Document { get; set; }
        public System.Int32? Number_Of_Pages { get; set; }

    }
		
		
		 
}

