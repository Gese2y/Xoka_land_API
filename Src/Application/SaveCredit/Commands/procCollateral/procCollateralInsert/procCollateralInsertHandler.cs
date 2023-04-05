



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.SaveCredit;
using XOKA.Domain.Interfaces;


namespace Application.SaveCredit.Commands.procCollateral.procCollateralInsert.procCollateralInsertCommand
{

    /// @author  Shimels Alem  proc_CollateralInsert stored procedure.


    public class procCollateralInsertHandler : IRequestHandler<procCollateralInsertCommand, IList<Collateral_CollateralID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCollateralInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Collateral_CollateralID>> Handle( procCollateralInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Collateral_CollateralID> result = await _procedureAdabter
                .Execute<Collateral_CollateralID>("[SaveCredit].proc_CollateralInsert", request);
           

            return result;
        }
    }
}
 