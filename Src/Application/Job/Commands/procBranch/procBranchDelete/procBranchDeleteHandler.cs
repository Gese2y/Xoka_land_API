using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBranch.procBranchDelete.procBranchDeleteCommand
{

    /// @author  Shimels Alem  proc_BranchDelete stored procedure.


    public class procBranchDeleteHandler : IRequestHandler<procBranchDeleteCommand, IList<Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBranchDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Branch_ID>> Handle( procBranchDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Branch_ID> result = await _procedureAdabter
                .Execute<Branch_ID>("[Job].proc_BranchDelete", request);
           

            return result;
        }
    }
}
  