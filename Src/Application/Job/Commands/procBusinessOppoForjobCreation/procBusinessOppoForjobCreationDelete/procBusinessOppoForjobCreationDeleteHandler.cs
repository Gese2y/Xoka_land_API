using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBusinessOppoForjobCreation.procBusinessOppoForjobCreationDelete.procBusinessOppoForjobCreationDeleteCommand
{

    /// @author  Shimels Alem  proc_Business_Oppo_For__job_CreationDelete stored procedure.


    public class procBusinessOppoForjobCreationDeleteHandler : IRequestHandler<procBusinessOppoForjobCreationDeleteCommand, IList<BusinessOppoForjobCreation_BUSOPPID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBusinessOppoForjobCreationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BusinessOppoForjobCreation_BUSOPPID>> Handle( procBusinessOppoForjobCreationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BusinessOppoForjobCreation_BUSOPPID> result = await _procedureAdabter
                .Execute<BusinessOppoForjobCreation_BUSOPPID>("[Job].proc_Business_Oppo_For__job_CreationDelete", request);
           

            return result;
        }
    }
}
  