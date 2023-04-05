using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBazarAndExhibition.procBazarAndExhibitionDelete.procBazarAndExhibitionDeleteCommand
{

    /// @author  Shimels Alem  proc_Bazar&ExhibitionDelete stored procedure.


    public class procBazarAndExhibitionDeleteHandler : IRequestHandler<procBazarAndExhibitionDeleteCommand, IList<BazarAndExhibition_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBazarAndExhibitionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BazarAndExhibition_ID>> Handle( procBazarAndExhibitionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BazarAndExhibition_ID> result = await _procedureAdabter
                .Execute<BazarAndExhibition_ID>("[Job].proc_Bazar&ExhibitionDelete", request);
           

            return result;
        }
    }
}
  