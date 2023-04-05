using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procStakeholder.procStakeholderDelete.procStakeholderDeleteCommand
{

    /// @author  Shimels Alem  proc_MSE_EmployeeDelete stored procedure.


    public class procStakeholderDeleteHandler : IRequestHandler<procStakeholderDeleteCommand, IList<Stakeholder_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStakeholderDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Stakeholder_ID>> Handle( procStakeholderDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Stakeholder_ID> result = await _procedureAdabter
                .Execute<Stakeholder_ID>("[Job].proc_StakeholderDelete", request);
           

            return result;
        }
    }
}
  