

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Spatial;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procSheds.procShedsUpdate.procShedsUpdateCommand
{

    /// @author  Shimels Alem  proc_ShedsUpdate stored procedure.


    public class procShedsUpdateHandler : IRequestHandler<procShedsUpdateCommand, IList<Sheds_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShedsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sheds_ID>> Handle( procShedsUpdateCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID = request.ID;
            Geography? GEO_Location = request.GEO_Location;
            string Type = request.Type;
            int? Size = request.Size;
            byte[] Pic = request.Pic;
            IList<Sheds_ID> result = await _procedureAdabter
                .Execute<Sheds_ID>("[WorkSpace].proc_ShedsUpdate", 
                (nameof(ID), ID),
                (nameof(GEO_Location), GEO_Location),
                (nameof(Type), Type),
                (nameof(Size), Size),
                (nameof(Pic), Pic)
                );

            return result;
        }
    }
}
 