



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Trade;
using XOKA.Domain.Interfaces;


namespace Application.Trade.Commands.procOwnerInfo.procOwnerInfoInsert.procOwnerInfoInsertCommand
{

    /// @author  Shimels Alem  proc_Owner_InfoInsert stored procedure.


    public class procOwnerInfoInsertHandler : IRequestHandler<procOwnerInfoInsertCommand, IList<OwnerInfo_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procOwnerInfoInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OwnerInfo_ID>> Handle( procOwnerInfoInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID= request.ID;
            string Position= request.Position;
            string Full_Name= request.Full_Name;
            bool? IsActive= request.IsActive;
            bool? IS_GM= request.IS_GM;
            System.DateTime? Registration_Date= request.Registration_Date;
            byte[] Photo= request.Photo;
           string Company_TIn_NO= request.Company_TIn_NO;
            int? NO_Of_Share = request.NO_Of_Share;
            int? Share_Price = request.Share_Price;
            bool? IS_Current= request.IS_Current;
            System.DateTime? YEAR= request.YEAR;
            System.Guid? Parent = request.Parent;
            IList<OwnerInfo_ID> result = await _procedureAdabter
                    .Execute<OwnerInfo_ID>("[Trade].proc_Owner_InfoInsert",
                        (nameof(ID), ID),
                        (nameof(Position), Position),
                        (nameof(Full_Name), Full_Name),
                        (nameof(IsActive), IsActive),
                        (nameof(IS_GM), IS_GM),
                        (nameof(Registration_Date), Registration_Date),
                        (nameof(Photo), Photo),
                        (nameof(Company_TIn_NO), Company_TIn_NO),
                        (nameof(NO_Of_Share), NO_Of_Share),
                        (nameof(Share_Price), Share_Price),
                        (nameof(IS_Current), IS_Current),
                        (nameof(YEAR), YEAR),
                        (nameof(Parent), Parent)
                        );

            return result;
        }
    }
}
 