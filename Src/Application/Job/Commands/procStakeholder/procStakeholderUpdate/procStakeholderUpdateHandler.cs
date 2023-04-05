

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procStakeholder.procStakeholderUpdate.procStakeholderUpdateCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeUpdate stored procedure.


    public class procStakeholderUpdateHandler : IRequestHandler<procStakeholderUpdateCommand, IList<Stakeholder_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStakeholderUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Stakeholder_ID>> Handle( procStakeholderUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Stakeholder_ID> result = await _procedureAdabter
                .Execute<Stakeholder_ID>("[Job].proc_StakeholderUpdate", request);
           

            return result;
        }
    }
}
 