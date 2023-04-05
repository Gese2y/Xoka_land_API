using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Commands.procWorkExperience.procWorkExperienceDelete.procWorkExperienceDeleteCommand
{

    /// @author  Shimels Alem  proc_Work_ExperienceDelete stored procedure.


    public class procWorkExperienceDeleteHandler : IRequestHandler<procWorkExperienceDeleteCommand, IList<WorkExperience_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procWorkExperienceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkExperience_ID>> Handle( procWorkExperienceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<WorkExperience_ID> result = await _procedureAdabter
                .Execute<WorkExperience_ID>("[UnEmployment].proc_Work_ExperienceDelete", request);
           

            return result;
        }
    }
}
  