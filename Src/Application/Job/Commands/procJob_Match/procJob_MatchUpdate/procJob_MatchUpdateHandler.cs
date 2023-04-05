

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Match.procJob_MatchUpdate.procJob_MatchUpdateCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.


    public class procJob_MatchUpdateHandler : IRequestHandler<procJob_MatchUpdateCommand, IList<Job_Match_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_MatchUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Match_Id>> Handle( procJob_MatchUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Match_Id> result = await _procedureAdabter
                .Execute<Job_Match_Id>("[Job].proc_Job_MatchUpdate", request);
           

            return result;
        }
    }
}
 