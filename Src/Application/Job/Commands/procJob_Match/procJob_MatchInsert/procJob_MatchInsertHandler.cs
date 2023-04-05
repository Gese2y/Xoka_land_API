



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procJob_Match.procJob_MatchInsert.procJob_MatchInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_MatchInsertHandler : IRequestHandler<procJob_MatchInsertCommand, IList<Job_Match_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_MatchInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Match_Id>> Handle( procJob_MatchInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Match_Id> result = await _procedureAdabter
                .Execute<Job_Match_Id>("[Job].proc_Job_MatchInsert", request);
           

            return result;
        }
    }
}
 