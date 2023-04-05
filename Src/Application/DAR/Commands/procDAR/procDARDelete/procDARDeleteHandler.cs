using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Commands.procDAR.procDARDelete.procDARDeleteCommand
{

    /// @author  Shimels Alem  proc_DARDelete stored procedure.


    public class procDARDeleteHandler : IRequestHandler<procDARDeleteCommand, IList<DAR_DARNO>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procDARDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DAR_DARNO>> Handle( procDARDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<DAR_DARNO> result = await _procedureAdabter
                .Execute<DAR_DARNO>("[DAR].proc_DARDelete", request);
           

            return result;
        }
    }
}
  