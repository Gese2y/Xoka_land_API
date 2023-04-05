



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procEmploymentExperience.procEmploymentExperienceInsert.procEmploymentExperienceInsertCommand
{

    /// @author  Shimels Alem  proc_Employment_ExperienceInsert stored procedure.


    public class procEmploymentExperienceInsertHandler : IRequestHandler<procEmploymentExperienceInsertCommand, IList<EmploymentExperience_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEmploymentExperienceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmploymentExperience_ID>> Handle( procEmploymentExperienceInsertCommand request, CancellationToken cancellationToken)
        {
            Guid ID = request.ID;
            string EMP_TIN = request.EMP_TIN;
            string EMP_Pension_NO = request.EMP_Pension_NO;
            string Types_of_employment = request.Types_of_employment;
            DateTime? Start_Date = request.Start_Date;
            DateTime? End_Date = request.End_Date;
            Double? basic_Salary = request.basic_Salary;
            string Reference = request.Reference;
            Guid? Created_By = request.Created_By;
            Guid? Updated_By = request.Updated_By;
            Byte[]? Date_log = request.Date_log;
            IList<EmploymentExperience_ID> result = await _procedureAdabter
                    .Execute<EmploymentExperience_ID>("[Job].proc_Employment_ExperienceInsert",
                    (nameof(ID), ID),
                    (nameof(EMP_TIN), EMP_TIN),
                    (nameof(EMP_Pension_NO), EMP_Pension_NO),
                    (nameof(Types_of_employment), Types_of_employment),
                    (nameof(Start_Date), Start_Date),
                    (nameof(End_Date), End_Date),
                    (nameof(basic_Salary), basic_Salary),
                    (nameof(Reference), Reference),
                    (nameof(Created_By), Created_By),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Date_log), Date_log)
                    );
           

            return result;
        }
    }
}
 