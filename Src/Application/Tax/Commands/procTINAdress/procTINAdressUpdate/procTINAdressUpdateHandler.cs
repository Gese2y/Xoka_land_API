

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procTINAdress.procTINAdressUpdate.procTINAdressUpdateCommand
{

    /// @author  Shimels Alem  proc_TIN_AdressUpdate stored procedure.


    public class procTINAdressUpdateHandler : IRequestHandler<procTINAdressUpdateCommand, IList<TINAdress_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTINAdressUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TINAdress_ID>> Handle( procTINAdressUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<TINAdress_ID> result = await _procedureAdabter
                .Execute<TINAdress_ID>("[Tax].proc_TIN_AdressUpdate", request);
           

            return result;
        }
    }
}
 