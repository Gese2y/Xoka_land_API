



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Spatial;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;


namespace Application.WorkSpace.Commands.procSheds.procShedsInsert.procShedsInsertCommand
{

    /// @author  Shimels Alem  proc_ShedsInsert stored procedure.


    public class procShedsInsertHandler : IRequestHandler<procShedsInsertCommand, IList<Sheds_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShedsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Sheds_ID>> Handle( procShedsInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID = request.ID;
            Geography? GEO_Location = request.GEO_Location;
            string Type = request.Type;
            int? Size = request.Size;
            byte[] Pic = request.Pic;
            IList<Sheds_ID> result = await _procedureAdabter
                    .Execute<Sheds_ID>("[WorkSpace].proc_ShedsInsert",
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
 