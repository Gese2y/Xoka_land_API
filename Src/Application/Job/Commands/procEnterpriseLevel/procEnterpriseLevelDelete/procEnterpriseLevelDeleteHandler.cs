using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseLevel.procEnterpriseLevelDelete.procEnterpriseLevelDeleteCommand
{

    /// @author  Shimels Alem  proc_Enterprise_LevelDelete stored procedure.


    public class procEnterpriseLevelDeleteHandler : IRequestHandler<procEnterpriseLevelDeleteCommand, IList<EnterpriseLevel_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseLevelDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseLevel_Code>> Handle( procEnterpriseLevelDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<EnterpriseLevel_Code> result = await _procedureAdabter
                .Execute<EnterpriseLevel_Code>("[Job].proc_Enterprise_LevelDelete", request);
           

            return result;
        }
    }
}
  