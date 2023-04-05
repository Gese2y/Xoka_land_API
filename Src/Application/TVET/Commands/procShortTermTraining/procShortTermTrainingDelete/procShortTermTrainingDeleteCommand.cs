 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procShortTermTraining.procShortTermTrainingDelete.procShortTermTrainingDeleteCommand
{

    // @author  Shimels Alem  proc_Short_Term_TrainingDelete stored procedure.

    public class procShortTermTrainingDeleteCommand : IRequest<IList<ShortTermTraining_ID>>
    {
        public System.Guid ID { get; set; }
    }
		
     
		
		 
}
 
 