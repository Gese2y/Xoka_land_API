



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procRenewInfoChange.procRenewInfoChangeInsert.procRenewInfoChangeInsertCommand
{

    /// @author  Shimels Alem  proc_Renew_Info_ChangeInsert stored procedure.


    public class procRenewInfoChangeInsertHandler : IRequestHandler<procRenewInfoChangeInsertCommand, IList<RenewInfoChange_ChangeID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRenewInfoChangeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RenewInfoChange_ChangeID>> Handle( procRenewInfoChangeInsertCommand request, CancellationToken cancellationToken)
        {

			System.Guid Change_ID = request.Change_ID;
			string ID = request.ID;
			string Issue_Type = request.Issue_Type;
			string Issue_Reason = request.Issue_Reason;
			string FName = request.FName;
			string MName = request.MName;
			string LName = request.LName;
			System.DateTime? Date_Issued = request.Date_Issued;
			System.DateTime? Exp_Date = request.Exp_Date;
			string Region = request.Region;
			string Zone_SubCity = request.Zone_SubCity;
			string Woreda_Kebele = request.Woreda_Kebele;
			string House_NO = request.House_NO;
			string Phone = request.Phone;
			string Emergency_Contact_Name = request.Emergency_Contact_Name;
			string Emergency_Contact_Phone = request.Emergency_Contact_Phone;
			byte[] Photo = request.Photo;
			byte[] Finger = request.Finger;
			bool? Is_Active = request.Is_Active;
			System.Guid? Regstered_Org = request.Regstered_Org;
			System.Guid? User_ID = request.User_ID;
			System.DateTime? created_date = request.created_date;
			System.DateTime? Updated_date = request.Updated_date;
			System.Guid? Updated_By_user = request.Updated_By_user;
			System.Guid? Parent = request.Parent;
			IList<RenewInfoChange_ChangeID> result = await _procedureAdabter
					.Execute<RenewInfoChange_ChangeID>("[Trade].proc_Renew_Info_ChangeInsert",
						(nameof(Change_ID), Change_ID),
						(nameof(ID), ID),
						(nameof(Issue_Type), Issue_Type),
						(nameof(Issue_Reason), Issue_Reason),
						(nameof(FName), FName),
						(nameof(MName), MName),
						(nameof(LName), LName),
						(nameof(Date_Issued), Date_Issued),
						(nameof(Exp_Date), Exp_Date),
						(nameof(Region), Region),
						(nameof(Zone_SubCity), Zone_SubCity),
						(nameof(Woreda_Kebele), Woreda_Kebele),
						(nameof(House_NO), House_NO),
						(nameof(Phone), Phone),
						(nameof(Emergency_Contact_Name), Emergency_Contact_Name),
						(nameof(Emergency_Contact_Phone), Emergency_Contact_Phone),
						(nameof(Photo), Photo),
						(nameof(Finger), Finger),
						(nameof(Is_Active), Is_Active),
						(nameof(Regstered_Org), Regstered_Org),
						(nameof(User_ID), User_ID),
						(nameof(created_date), created_date),
						(nameof(Updated_date), Updated_date),
						(nameof(Updated_By_user), Updated_By_user),
						(nameof(Parent), Parent)
						);
           
            return result;
        }
    }
}
 