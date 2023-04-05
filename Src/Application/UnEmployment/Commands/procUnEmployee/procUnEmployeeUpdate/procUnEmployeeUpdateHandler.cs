

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeUpdate.procUnEmployeeUpdateCommand
{

    /// @author  Shimels Alem  proc_UnEmployeeUpdate stored procedure.


    public class procUnEmployeeUpdateHandler : IRequestHandler<procUnEmployeeUpdateCommand, IList<UnEmployee_TIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procUnEmployeeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<UnEmployee_TIN>> Handle( procUnEmployeeUpdateCommand request, CancellationToken cancellationToken)
        {
            string TIN = request.TIN;
            string Vital_ID = request.Vital_ID;
            string Full_Name = request.Full_Name;
            string Status = request.Status;
            byte[] Photo = request.Photo;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            byte[] Date_log = request.Date_log;
            Guid? UnEmployeeRequest_ID = request.UnEmployeeRequest_ID;
            string Unemployment_Number = request.Unemployment_Number;
            System.DateTime? Date_Issued = request.Date_Issued;
            string Physical_Condition = request.Physical_Condition;
            string Refugee_Status = request.Refugee_Status;
            string HIV_Status = request.HIV_Status;
            string Returnee_Status = request.Returnee_Status;
            string Gender = request.Gender;
            IList<UnEmployee_TIN> result = await _procedureAdabter
                .Execute<UnEmployee_TIN>("[UnEmployment].[proc_UnEmployeeUpdate]",
                (nameof(TIN), TIN),
                (nameof(Vital_ID), Vital_ID),
                (nameof(Full_Name), Full_Name),
                (nameof(Status), Status),
                (nameof(Photo), Photo),
                (nameof(Created_By), Created_By),
                (nameof(Updated_By), Updated_By),
                (nameof(Date_log), Date_log),
                (nameof(UnEmployeeRequest_ID), UnEmployeeRequest_ID),
                (nameof(Unemployment_Number), Unemployment_Number),
                (nameof(Date_Issued), Date_Issued),
                (nameof(Physical_Condition), Physical_Condition),
                (nameof(Refugee_Status), Refugee_Status),
                (nameof(HIV_Status), HIV_Status),
                (nameof(Returnee_Status), Returnee_Status),
                (nameof(Gender), Gender));
           

            return result;
        }
    }
}
 