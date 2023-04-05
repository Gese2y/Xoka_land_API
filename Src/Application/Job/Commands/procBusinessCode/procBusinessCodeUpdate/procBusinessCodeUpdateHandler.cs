

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBusinessCode.procBusinessCodeUpdate.procBusinessCodeUpdateCommand
{

    /// @author  Shimels Alem  proc_Business_CodeUpdate stored procedure.


    public class procBusinessCodeUpdateHandler : IRequestHandler<procBusinessCodeUpdateCommand, IList<BusinessCode_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBusinessCodeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BusinessCode_Code>> Handle( procBusinessCodeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<BusinessCode_Code> result = await _procedureAdabter
                .Execute<BusinessCode_Code>("[Job].proc_Business_CodeUpdate", request);
           

            return result;
        }
    }
}
 