 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsDelete.procEnterprise_Grade_Points_DetailsDeleteCommand
{

    // @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.

    public class procEnterprise_Grade_Points_DetailsDeleteCommand : IRequest<IList<Enterprise_Grade_Points_Details_ID>>
    {
        public string ID { get; set; }
    }
		
     
		
		 
}
 
 