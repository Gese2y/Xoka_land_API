using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procAssets.procAssetsDelete.procAssetsDeleteCommand
{

    /// @author  Shimels Alem  proc_AssetsDelete stored procedure.


    public class procAssetsDeleteHandler : IRequestHandler<procAssetsDeleteCommand, IList<Assets_FIXEDAssetNo>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAssetsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Assets_FIXEDAssetNo>> Handle( procAssetsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Assets_FIXEDAssetNo> result = await _procedureAdabter
                .Execute<Assets_FIXEDAssetNo>("[Job].proc_AssetsDelete", request);
           

            return result;
        }
    }
}
  