



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procJob_Position.procJob_PositionInsert.procJob_PositionInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procJob_PositionInsertHandler : IRequestHandler<procJob_PositionInsertCommand, IList<Job_Position_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJob_PositionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Job_Position_Id>> Handle( procJob_PositionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Job_Position_Id> result = await _procedureAdabter
                .Execute<Job_Position_Id>("[Job].proc_Job_PositionInsert", request);
           

            return result;
        }
    }
}
 