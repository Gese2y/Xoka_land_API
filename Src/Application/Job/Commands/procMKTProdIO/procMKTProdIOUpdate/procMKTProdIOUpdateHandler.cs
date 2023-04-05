

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Job;
using System.Collections.Generic;

namespace Application.Job.Commands.procMKTProdIO.procMKTProdIOUpdate.procMKTProdIOUpdateCommand
{

    /// @author  Shimels Alem  proc_MKT_Prod_IOUpdate stored procedure.


    public class procMKTProdIOUpdateHandler : IRequestHandler<procMKTProdIOUpdateCommand, IList<MKTProdIO_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMKTProdIOUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MKTProdIO_ID>> Handle( procMKTProdIOUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<MKTProdIO_ID> result = await _procedureAdabter
                .Execute<MKTProdIO_ID>("[dbo].proc_MKT_Prod_IOUpdate", request);
           

            return result;
        }
    }
}
 