



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procEducation.procEducationInsert.procEducationInsertCommand
{

    /// @author  Shimels Alem  proc_EducationInsert stored procedure.


    public class procEducationInsertHandler : IRequestHandler<procEducationInsertCommand, IList<Education_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEducationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Education_ID>> Handle( procEducationInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID = request.ID;
            string EMP_TIN = request.EMP_TIN;
            string Level = request.Level;
            string Instiutution = request.Instiutution;
            System.DateTime? Graduate_Date = request.Graduate_Date;
            System.Guid? Doc_ID = request.Doc_ID;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            System.Byte[]? Date_log = request.Date_log;
           string Eduction_Types = request.Eduction_Types;
            IList<Education_ID> result = await _procedureAdabter
                    .Execute<Education_ID>("[Job].proc_EducationInsert",
                    (nameof(ID), ID),
                    (nameof(EMP_TIN), EMP_TIN),
                    (nameof(Level), Level),
                    (nameof(Instiutution), Instiutution),
                    (nameof(Graduate_Date), Graduate_Date),
                    (nameof(Doc_ID), Doc_ID),
                    (nameof(Created_By), Created_By),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Date_log), Date_log),
                    (nameof(Eduction_Types), Eduction_Types)
                    );
           

                return result;
        }
    }
}
 