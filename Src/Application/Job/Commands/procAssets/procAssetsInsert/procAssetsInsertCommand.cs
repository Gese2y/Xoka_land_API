


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procAssets.procAssetsInsert.procAssetsInsertCommand
{

    /// @author  Shimels Alem  proc_AssetsInsert stored procedure.


    public class procAssetsInsertCommand : IRequest<IList<Assets_FIXEDAssetNo>>
    {
		public string FIXED_Asset_No { get; set; }
		public System.Guid? FixedAsset_Trans_ID { get; set; }
		public string Name { get; set; }
		public string Factory_Number { get; set; }
		public System.Double? Value { get; set; }
		public System.DateTime? Purchased_Date { get; set; }
		public System.DateTime? Received_Date { get; set; }
		public System.DateTime? Commission_Date { get; set; }
		public System.DateTime? Depreciation_Start_Date { get; set; }
		public string Record_No { get; set; }
		public System.Int32? Quantity { get; set; }
		public string Unit { get; set; }
		public string Remark { get; set; }
		public System.Guid? document_detail_id { get; set; }
		public System.Guid? Owner_Org { get; set; }
	}
		
		
		 
}
 
 