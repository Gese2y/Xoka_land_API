

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procIncomeTax.procIncomeTaxUpdate.procIncomeTaxUpdateCommand
{

    /// @author  Shimels Alem  proc_Income_TaxUpdate stored procedure.


    public class procIncomeTaxUpdateHandler : IRequestHandler<procIncomeTaxUpdateCommand, IList<IncomeTax_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procIncomeTaxUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<IncomeTax_ID>> Handle( procIncomeTaxUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<IncomeTax_ID> result = await _procedureAdabter
                .Execute<IncomeTax_ID>("[Tax].proc_Income_TaxUpdate", request);
           

            return result;
        }
    }
}
 