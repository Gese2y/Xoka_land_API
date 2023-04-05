using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Commands.procEmploymentExperience.procEmploymentExperienceDelete.procEmploymentExperienceDeleteCommand
{

    /// @author  Shimels Alem  proc_Employment_ExperienceDelete stored procedure.


    public class procEmploymentExperienceDeleteHandler : IRequestHandler<procEmploymentExperienceDeleteCommand, IList<EmploymentExperience_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEmploymentExperienceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmploymentExperience_ID>> Handle( procEmploymentExperienceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<EmploymentExperience_ID> result = await _procedureAdabter
                .Execute<EmploymentExperience_ID>("[UnEmployment].proc_Employment_ExperienceDelete", request);
           

            return result;
        }
    }
}
  