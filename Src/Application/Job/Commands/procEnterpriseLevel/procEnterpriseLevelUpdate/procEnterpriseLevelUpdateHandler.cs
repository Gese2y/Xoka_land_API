

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseLevel.procEnterpriseLevelUpdate.procEnterpriseLevelUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_LevelUpdate stored procedure.


    public class procEnterpriseLevelUpdateHandler : IRequestHandler<procEnterpriseLevelUpdateCommand, IList<EnterpriseLevel_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseLevelUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseLevel_Code>> Handle( procEnterpriseLevelUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseLevel_Code> result = await _procedureAdabter
                .Execute<EnterpriseLevel_Code>("[Job].proc_Enterprise_LevelUpdate", request);
           

            return result;
        }
    }
}
 