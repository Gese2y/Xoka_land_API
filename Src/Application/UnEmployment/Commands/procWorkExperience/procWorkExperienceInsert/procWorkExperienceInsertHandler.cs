



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;


namespace Application.UnEmployment.Commands.procWorkExperience.procWorkExperienceInsert.procWorkExperienceInsertCommand
{

    /// @author  Shimels Alem  proc_Work_ExperienceInsert stored procedure.


    public class procWorkExperienceInsertHandler : IRequestHandler<procWorkExperienceInsertCommand, IList<WorkExperience_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procWorkExperienceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WorkExperience_ID>> Handle( procWorkExperienceInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID = request.ID;
            string EMP_TIN = request.EMP_TIN;
            string Experience = request.Experience;
            double? NO_OF_years = request.NO_OF_years;
            System.Guid? Doc_ID = request.Doc_ID;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            byte[] Date_log = request.Date_log;
            string Job_Position_ID = request.Job_Position_ID;
            IList<WorkExperience_ID> result = await _procedureAdabter
                    .Execute<WorkExperience_ID>("[UnEmployment].proc_Work_ExperienceInsert",
                    (nameof(ID), ID),
                    (nameof(EMP_TIN), EMP_TIN),
                    (nameof(Experience), Experience),
                    (nameof(NO_OF_years), NO_OF_years),
                    (nameof(Doc_ID), Doc_ID),
                    (nameof(Created_By), Created_By),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Date_log), Date_log),
                    (nameof(Job_Position_ID), Job_Position_ID)
                    );
           

            return result;
        }
    }
}
 