using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseLevel.procEnterpriseLevelUpdate.procEnterpriseLevelUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_LevelUpdate stored procedure.

    public class procEnterpriseLevelUpdateCommand : IRequest<IList<EnterpriseLevel_Code>>
   {
        public string Code { get; set; }
        public string name { get; set; }
        public System.Double? Capital { get; set; }
        public string Ent_Level_Type { get; set; }
        public string Size { get; set; }
    }
		
		
		 
}

