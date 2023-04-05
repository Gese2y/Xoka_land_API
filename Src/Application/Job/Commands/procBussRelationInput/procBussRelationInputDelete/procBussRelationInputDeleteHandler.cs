using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBussRelationInput.procBussRelationInputDelete.procBussRelationInputDeleteCommand
{

    /// @author  Shimels Alem  proc_Buss_Relation_InputDelete stored procedure.


    public class procBussRelationInputDeleteHandler : IRequestHandler<procBussRelationInputDeleteCommand, IList<BussRelationInput_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBussRelationInputDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BussRelationInput_ID>> Handle( procBussRelationInputDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BussRelationInput_ID> result = await _procedureAdabter
                .Execute<BussRelationInput_ID>("[Job].proc_Buss_Relation_InputDelete", request);
           

            return result;
        }
    }
}
  