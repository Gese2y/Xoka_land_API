

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;

namespace Application.SaveCredit.Commands.procCollateral.procCollateralUpdate.procCollateralUpdateCommand
{

    /// @author  Shimels Alem  proc_CollateralUpdate stored procedure.


    public class procCollateralUpdateHandler : IRequestHandler<procCollateralUpdateCommand, IList<Collateral_CollateralID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCollateralUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Collateral_CollateralID>> Handle( procCollateralUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Collateral_CollateralID> result = await _procedureAdabter
                .Execute<Collateral_CollateralID>("[SaveCredit].proc_CollateralUpdate", request);
           

            return result;
        }
    }
}
 