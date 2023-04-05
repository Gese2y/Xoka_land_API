



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procSector.procSectorInsert.procSectorInsertCommand
{

    /// @author  Shimels Alem  proc_Business_ActivityInsert stored procedure.


    public class procSectorInsertHandler : IRequestHandler<procSectorInsertCommand, IList<Sector_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procSectorInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sector_Code>> Handle( procSectorInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Sector_Code> result = await _procedureAdabter
                .Execute<Sector_Code>("[dbo].[proc_SectorsInsert]", request);
           

            return result;
        }
    }
}
 