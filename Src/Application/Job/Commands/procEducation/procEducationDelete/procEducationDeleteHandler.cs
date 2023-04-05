using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEducation.procEducationDelete.procEducationDeleteCommand
{

    /// @author  Shimels Alem  proc_EducationDelete stored procedure.


    public class procEducationDeleteHandler : IRequestHandler<procEducationDeleteCommand, IList<Education_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEducationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Education_ID>> Handle( procEducationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Education_ID> result = await _procedureAdabter
                .Execute<Education_ID>("[Job].proc_EducationDelete", request);
           

            return result;
        }
    }
}
  