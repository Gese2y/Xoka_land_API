using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procProduct.procProductDelete.procProductDeleteCommand
{

    /// @author  Shimels Alem  proc_ProductDelete stored procedure.


    public class procProductDeleteHandler : IRequestHandler<procProductDeleteCommand, IList<Product_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProductDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Product_ID>> Handle( procProductDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Product_ID> result = await _procedureAdabter
                .Execute<Product_ID>("[Job].proc_ProductDelete", request);
           

            return result;
        }
    }
}
  