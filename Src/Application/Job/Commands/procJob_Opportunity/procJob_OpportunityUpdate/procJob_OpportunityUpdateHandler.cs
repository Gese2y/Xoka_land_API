

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Opportunity.procJob_OpportunityUpdate.procJob_OpportunityUpdateCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.


    public class procJob_OpportunityUpdateHandler : IRequestHandler<procJob_OpportunityUpdateCommand, IList<Job_Opportunity_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_OpportunityUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Opportunity_Id>> Handle( procJob_OpportunityUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Opportunity_Id> result = await _procedureAdabter
                .Execute<Job_Opportunity_Id>("[Job].proc_Job_OpportunityUpdate", request);
           

            return result;
        }
    }
}
 