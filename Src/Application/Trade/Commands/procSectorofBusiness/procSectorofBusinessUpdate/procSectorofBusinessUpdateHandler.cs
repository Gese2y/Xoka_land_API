

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;

namespace Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessUpdate.procSectorofBusinessUpdateCommand
{

    /// @author  Shimels Alem  proc_Sector_of_BusinessUpdate stored procedure.


    public class procSectorofBusinessUpdateHandler : IRequestHandler<procSectorofBusinessUpdateCommand, IList<SectorofBusiness_TINAndCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSectorofBusinessUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SectorofBusiness_TINAndCode>> Handle( procSectorofBusinessUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SectorofBusiness_TINAndCode> result = await _procedureAdabter
                .Execute<SectorofBusiness_TINAndCode>("[Trade].proc_Sector_of_BusinessUpdate", request);
           

            return result;
        }
    }
}
 