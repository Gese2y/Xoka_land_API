

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procJob_Position.procJob_PositionUpdate.procJob_PositionUpdateCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.


    public class procJob_PositionUpdateHandler : IRequestHandler<procJob_PositionUpdateCommand, IList<Job_Position_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_PositionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Position_Id>> Handle( procJob_PositionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Position_Id> result = await _procedureAdabter
                .Execute<Job_Position_Id>("[Job].proc_Job_PositionUpdate", request);
           

            return result;
        }
    }
}
 