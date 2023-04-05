 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procbussinessRelationMKT.procbussinessRelationMKTDelete.procbussinessRelationMKTDeleteCommand
{

    // @author  Shimels Alem  proc_bussiness_Relation_MKTDelete stored procedure.

    public class procbussinessRelationMKTDeleteCommand : IRequest<IList<bussinessRelationMKT_ID>>
    {

        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 