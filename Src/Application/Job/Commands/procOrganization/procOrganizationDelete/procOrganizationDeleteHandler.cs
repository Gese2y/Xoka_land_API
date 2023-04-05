using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procOrganization.procOrganizationDelete.procOrganizationDeleteCommand
{

    /// @author  Shimels Alem  proc_AssetsDelete stored procedure.


    public class procOrganizationDeleteHandler : IRequestHandler<procOrganizationDeleteCommand, IList<Organization_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOrganizationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Organization_ID>> Handle(procOrganizationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Organization_ID> result = await _procedureAdabter
                .Execute<Organization_ID>("[dbo].proc_organizationsDelete", request);
           

            return result;
        }
    }
}
  