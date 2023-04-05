using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procIncomeTax.procIncomeTaxDelete.procIncomeTaxDeleteCommand
{

    /// @author  Shimels Alem  proc_Income_TaxDelete stored procedure.


    public class procIncomeTaxDeleteHandler : IRequestHandler<procIncomeTaxDeleteCommand, IList<IncomeTax_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procIncomeTaxDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<IncomeTax_ID>> Handle( procIncomeTaxDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<IncomeTax_ID> result = await _procedureAdabter
                .Execute<IncomeTax_ID>("[Tax].proc_Income_TaxDelete", request);
           

            return result;
        }
    }
}
  