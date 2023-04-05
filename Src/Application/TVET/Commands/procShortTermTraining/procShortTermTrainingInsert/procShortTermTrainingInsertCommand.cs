


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.TVET;

namespace Application.TVET.Commands.procShortTermTraining.procShortTermTrainingInsert.procShortTermTrainingInsertCommand
{

    /// @author  Shimels Alem  proc_Short_Term_TrainingInsert stored procedure.


    public class procShortTermTrainingInsertCommand : IRequest<IList<ShortTermTraining_ID>>
    {
        public System.Guid ID { get; set; }
        public string EMP_TIN { get; set; }
        public string Training_Type { get; set; }
        public string Instiutution { get; set; }
        public int? Passmark { get; set; }
        public System.Guid? Doc_ID { get; set; }
        public string Training_Name { get; set; }
    }
		
		
		 
}
 
 