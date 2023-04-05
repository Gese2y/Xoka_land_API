using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procSheds.procShedsDelete.procShedsDeleteCommand
{

    /// @author  Shimels Alem  proc_ShedsDelete stored procedure.


    public class procShedsDeleteHandler : IRequestHandler<procShedsDeleteCommand, IList<Sheds_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShedsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sheds_ID>> Handle( procShedsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Sheds_ID> result = await _procedureAdabter
                .Execute<Sheds_ID>("[WorkSpace].proc_ShedsDelete", request);
           

            return result;
        }
    }
}
  