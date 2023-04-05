using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procTIN.procTINDelete.procTINDeleteCommand
{

    /// @author  Shimels Alem  proc_TINDelete stored procedure.


    public class procTINDeleteHandler : IRequestHandler<procTINDeleteCommand, IList<TIN_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTINDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TIN_ID>> Handle( procTINDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<TIN_ID> result = await _procedureAdabter
                .Execute<TIN_ID>("[Tax].proc_TINDelete", request);
           

            return result;
        }
    }
}
  