



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procMSEEmployee.procMSEEmployeeInsert.procMSEEmployeeInsertCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeInsert stored procedure.


    public class procMSEEmployeeInsertHandler : IRequestHandler<procMSEEmployeeInsertCommand, IList<MSEEmployee_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMSEEmployeeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MSEEmployee_ID>> Handle( procMSEEmployeeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<MSEEmployee_ID> result = await _procedureAdabter
                .Execute<MSEEmployee_ID>("[Job].proc_MSE_EmployeeInsert", request);
           

            return result;
        }
    }
}
 