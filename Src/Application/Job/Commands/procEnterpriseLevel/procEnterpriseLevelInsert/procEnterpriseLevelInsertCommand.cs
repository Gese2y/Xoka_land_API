


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procEnterpriseLevel.procEnterpriseLevelInsert.procEnterpriseLevelInsertCommand
{

    /// @author  Shimels Alem  proc_Enterprise_LevelInsert stored procedure.


    public class procEnterpriseLevelInsertCommand : IRequest<IList<EnterpriseLevel_Code>>
    {
        public string Code { get; set; }
        public string name { get; set; }
        public System.Double? Capital { get; set; }
        public string Ent_Level_Type { get; set; }
        public string Size { get; set; }
    }
		
		
		 
}
 
 