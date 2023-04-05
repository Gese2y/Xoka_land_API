using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Opp_Education_Types.procJob_Opp_Education_TypesDelete.procJob_Opp_Education_TypesDeleteCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.


    public class procJob_Opp_Education_TypesDeleteHandler : IRequestHandler<procJob_Opp_Education_TypesDeleteCommand, IList<Job_Opp_Education_Types_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_Opp_Education_TypesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Opp_Education_Types_Id>> Handle( procJob_Opp_Education_TypesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Opp_Education_Types_Id> result = await _procedureAdabter
                .Execute<Job_Opp_Education_Types_Id>("[Job].proc_Job_Opp_Education_TypesDelete", request);
           

            return result;
        }
    }
}
  