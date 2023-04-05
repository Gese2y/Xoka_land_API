﻿using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Tax;

namespace Application.Tax.Commands.procTINERCA.procTINERCAUpdate.procTINERCAUpdateCommand
{

	/// @author  Shimels Alem  proc_TIN_ERCAUpdate stored procedure.

	public class procTINERCAUpdateCommand : IRequest<IList<TINERCA_TIN>>
   {
		public string TIN { get; set; }
		public System.DateTime? Date_Regstered { get; set; }
		public string TIN_Type { get; set; }
		public System.Guid? ORG_ID { get; set; }
		public string Status { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public byte[] Date_log { get; set; }
		public System.Guid? Licence_ID { get; set; }
		public string Company_Name { get; set; }
		public string Tax_Center { get; set; }
		public string DAR_NO { get; set; }
	}
		
		
		 
}

