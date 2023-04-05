



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;


namespace Application.UnEmployment.Commands.procunEmployeeRequest.procunEmployeeRequestInsert.procunEmployeeRequestInsertCommand
{

    /// @author  Shimels Alem  proc_unEmployeeRequestInsert stored procedure.


    public class procunEmployeeRequestInsertHandler : IRequestHandler<procunEmployeeRequestInsertCommand, IList<unEmployeeRequest_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procunEmployeeRequestInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<unEmployeeRequest_Id>> Handle( procunEmployeeRequestInsertCommand request, CancellationToken cancellationToken)
        {

            System.Guid Id = request.Id;
            string TIN = request.TIN;
            string Vital_ID = request.Vital_ID;
            string Full_Name = request.Full_Name;
            string Type = request.Type;
            byte[] Photo = request.Photo;
            string Region = request.Region;
            string Zone = request.Zone;
            string Woreda = request.Woreda;
            string kebele = request.kebele;
            string House_Number = request.House_Number;
            string Mobile_No = request.Mobile_No;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            byte[] Date_log = request.Date_log;
            System.Guid? Licence_Service_Id = request.Licence_Service_Id;
            IList<unEmployeeRequest_Id> result = await _procedureAdabter
                .Execute<unEmployeeRequest_Id>("[UnEmployment].proc_unEmployeeRequestInsert",
                (nameof(Id), Id),
                (nameof(TIN), TIN),
                (nameof(Vital_ID), Vital_ID),
                (nameof(Full_Name), Full_Name),
                (nameof(Type), Type),
                (nameof(Photo), Photo),
                (nameof(Region), Region),
                (nameof(Zone), Zone),
                (nameof(Woreda), Woreda),
                (nameof(kebele), kebele),
                (nameof(House_Number), House_Number),
                (nameof(Mobile_No), Mobile_No),
                (nameof(Created_By), Created_By),
                (nameof(Updated_By), Updated_By),
                (nameof(Date_log), Date_log),
                (nameof(Licence_Service_Id), Licence_Service_Id)
                );
           

            return result;
        }
    }
}
 