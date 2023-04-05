﻿



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Spatial;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;


namespace Application.WorkSpace.Commands.procShedStatus.procShedStatusInsert.procShedStatusInsertCommand
{

    /// @author  Shimels Alem  proc_Shed_StatusInsert stored procedure.


    public class procShedStatusInsertHandler : IRequestHandler<procShedStatusInsertCommand, IList<ShedStatus_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procShedStatusInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ShedStatus_ID>> Handle( procShedStatusInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID = request.ID;
            byte[] Stutus = request.Stutus;
            Geography Construction_Place = request.Construction_Place;
            System.Decimal? Cost = request.Cost;
            string Contactor = request.Contactor;
            IList<ShedStatus_ID> result = await _procedureAdabter
                    .Execute<ShedStatus_ID>("[WorkSpace].proc_Shed_StatusInsert",
                    (nameof(ID), ID),
                    (nameof(Stutus), Stutus),
                    (nameof(Construction_Place), Construction_Place),
                    (nameof(Cost), Cost),
                    (nameof(Contactor), Contactor)
                    );
           

            return result;
        }
    }
}
 