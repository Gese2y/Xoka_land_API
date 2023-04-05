

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procAssets.procAssetsUpdate.procAssetsUpdateCommand
{

    /// @author  Shimels Alem  proc_AssetsUpdate stored procedure.


    public class procAssetsUpdateHandler : IRequestHandler<procAssetsUpdateCommand, IList<Assets_FIXEDAssetNo>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAssetsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Assets_FIXEDAssetNo>> Handle( procAssetsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Assets_FIXEDAssetNo> result = await _procedureAdabter
                .Execute<Assets_FIXEDAssetNo>("[Job].proc_AssetsUpdate", request);
           

            return result;
        }
    }
}
 