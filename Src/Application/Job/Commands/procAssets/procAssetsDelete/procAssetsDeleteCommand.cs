 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procAssets.procAssetsDelete.procAssetsDeleteCommand
{

    // @author  Shimels Alem  proc_AssetsDelete stored procedure.

    public class procAssetsDeleteCommand : IRequest<IList<Assets_FIXEDAssetNo>>
    {

        public string FIXED_Asset_No { get; set; }
    }
		
     
		
		 
}
 
 