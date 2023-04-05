



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procSectorofBusiness.procSectorofBusinessInsert.procSectorofBusinessInsertCommand
{

    /// @author  Shimels Alem  proc_Sector_of_BusinessInsert stored procedure.


    public class procSectorofBusinessInsertHandler : IRequestHandler<procSectorofBusinessInsertCommand, IList<SectorofBusiness_TINAndCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSectorofBusinessInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SectorofBusiness_TINAndCode>> Handle( procSectorofBusinessInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SectorofBusiness_TINAndCode> result = await _procedureAdabter
                .Execute<SectorofBusiness_TINAndCode>("[Trade].proc_Sector_of_BusinessInsert", request);
           

            return result;
        }
    }
}
 