

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMSEEmployee.procMSEEmployeeUpdate.procMSEEmployeeUpdateCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.


    public class procMSEEmployeeUpdateHandler : IRequestHandler<procMSEEmployeeUpdateCommand, IList<MSEEmployee_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMSEEmployeeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MSEEmployee_ID>> Handle( procMSEEmployeeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MSEEmployee_ID> result = await _procedureAdabter
                .Execute<MSEEmployee_ID>("[Job].proc_MSE_EmployeeUpdate", request);
           

            return result;
        }
    }
}
 