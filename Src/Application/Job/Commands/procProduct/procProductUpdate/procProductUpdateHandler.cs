

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procProduct.procProductUpdate.procProductUpdateCommand
{

    /// @author  Shimels Alem  proc_ProductUpdate stored procedure.


    public class procProductUpdateHandler : IRequestHandler<procProductUpdateCommand, IList<Product_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProductUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Product_ID>> Handle( procProductUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Product_ID> result = await _procedureAdabter
                .Execute<Product_ID>("[Job].proc_ProductUpdate", request);
           

            return result;
        }
    }
}
 