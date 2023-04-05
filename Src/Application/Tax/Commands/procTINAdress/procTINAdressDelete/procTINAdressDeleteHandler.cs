using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procTINAdress.procTINAdressDelete.procTINAdressDeleteCommand
{

    /// @author  Shimels Alem  proc_TIN_AdressDelete stored procedure.


    public class procTINAdressDeleteHandler : IRequestHandler<procTINAdressDeleteCommand, IList<TINAdress_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTINAdressDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TINAdress_ID>> Handle( procTINAdressDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<TINAdress_ID> result = await _procedureAdabter
                .Execute<TINAdress_ID>("[Tax].proc_TIN_AdressDelete", request);
           

            return result;
        }
    }
}
  