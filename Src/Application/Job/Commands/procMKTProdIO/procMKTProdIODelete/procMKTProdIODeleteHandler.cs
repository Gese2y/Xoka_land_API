using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procMKTProdIO.procMKTProdIODelete.procMKTProdIODeleteCommand
{

    /// @author  Shimels Alem  proc_MKT_Prod_IODelete stored procedure.


    public class procMKTProdIODeleteHandler : IRequestHandler<procMKTProdIODeleteCommand, IList<MKTProdIO_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMKTProdIODeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MKTProdIO_ID>> Handle( procMKTProdIODeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MKTProdIO_ID> result = await _procedureAdabter
                .Execute<MKTProdIO_ID>("[dbo].proc_MKT_Prod_IODelete", request);
           

            return result;
        }
    }
}
  