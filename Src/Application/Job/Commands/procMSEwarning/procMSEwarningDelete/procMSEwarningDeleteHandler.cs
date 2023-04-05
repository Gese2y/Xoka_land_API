using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procMSEwarning.procMSEwarningDelete.procMSEwarningDeleteCommand
{

    /// @author  Shimels Alem  proc_MSEwarning_ID_Delete stored procedure.


    public class procMSEwarningDeleteHandler : IRequestHandler<procMSEwarningDeleteCommand, IList<MSEwarning_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procMSEwarningDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<MSEwarning_ID>> Handle(procMSEwarningDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<MSEwarning_ID> result = await _procedureAdabter
                .Execute<MSEwarning_ID>("[dbo].proc_Enterprise_WarningDelete", request);
           

            return result;
        }
    }
}
  