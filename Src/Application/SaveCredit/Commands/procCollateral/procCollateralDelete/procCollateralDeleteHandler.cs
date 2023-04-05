using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procCollateral.procCollateralDelete.procCollateralDeleteCommand
{

    /// @author  Shimels Alem  proc_CollateralDelete stored procedure.


    public class procCollateralDeleteHandler : IRequestHandler<procCollateralDeleteCommand, IList<Collateral_CollateralID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCollateralDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Collateral_CollateralID>> Handle( procCollateralDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Collateral_CollateralID> result = await _procedureAdabter
                .Execute<Collateral_CollateralID>("[SaveCredit].proc_CollateralDelete", request);
           

            return result;
        }
    }
}
  