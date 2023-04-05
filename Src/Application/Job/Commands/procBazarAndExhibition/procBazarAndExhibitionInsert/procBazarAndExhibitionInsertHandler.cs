



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procBazarAndExhibition.procBazarAndExhibitionInsert.procBazarAndExhibitionInsertCommand
{

    /// @author  Shimels Alem  proc_Bazar&ExhibitionInsert stored procedure.


    public class procBazarAndExhibitionInsertHandler : IRequestHandler<procBazarAndExhibitionInsertCommand, IList<BazarAndExhibition_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBazarAndExhibitionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BazarAndExhibition_ID>> Handle( procBazarAndExhibitionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<BazarAndExhibition_ID> result = await _procedureAdabter
                .Execute<BazarAndExhibition_ID>("[Job].proc_Bazar&ExhibitionInsert", request);
           

            return result;
        }
    }
}
 