



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procJob_Opp_Education_Types.procJob_Opp_Education_TypesInsert.procJob_Opp_Education_TypesInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_Opp_Education_TypesInsertHandler : IRequestHandler<procJob_Opp_Education_TypesInsertCommand, IList<Job_Opp_Education_Types_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_Opp_Education_TypesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Opp_Education_Types_Id>> Handle( procJob_Opp_Education_TypesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Opp_Education_Types_Id> result = await _procedureAdabter
                .Execute<Job_Opp_Education_Types_Id>("[Job].proc_Job_Opp_Education_TypesInsert", request);
           

            return result;
        }
    }
}
 