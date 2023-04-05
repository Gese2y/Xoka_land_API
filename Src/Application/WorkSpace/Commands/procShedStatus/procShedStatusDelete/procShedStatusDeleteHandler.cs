using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procShedStatus.procShedStatusDelete.procShedStatusDeleteCommand
{

    /// @author  Shimels Alem  proc_Shed_StatusDelete stored procedure.


    public class procShedStatusDeleteHandler : IRequestHandler<procShedStatusDeleteCommand, IList<ShedStatus_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShedStatusDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShedStatus_ID>> Handle( procShedStatusDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ShedStatus_ID> result = await _procedureAdabter
                .Execute<ShedStatus_ID>("[WorkSpace].proc_Shed_StatusDelete", request);
           

            return result;
        }
    }
}
  