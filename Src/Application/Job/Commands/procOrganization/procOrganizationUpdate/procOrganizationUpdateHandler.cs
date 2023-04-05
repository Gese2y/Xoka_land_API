

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procOrganization.procOrganizationUpdate.procOrganizationUpdateCommand
{

    /// @author  Shimels Alem  proc_AssetsUpdate stored procedure.


    public class procOrganizationUpdateHandler : IRequestHandler<procOrganizationUpdateCommand, IList<Organization_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOrganizationUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Organization_ID>> Handle(procOrganizationUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Organization_ID> result = await _procedureAdabter
                .Execute<Organization_ID>("[dbo].proc_organizationsUpdate", request);
           

            return result;
        }
    }
}
 