

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Commands.procEnterpriseWorkSpaceRent.procEnterpriseWorkSpaceRentUpdate.procEnterpriseWorkSpaceRentUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_Work_Space_RentUpdate stored procedure.


    public class procEnterpriseWorkSpaceRentUpdateHandler : IRequestHandler<procEnterpriseWorkSpaceRentUpdateCommand, IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseWorkSpaceRentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>> Handle( procEnterpriseWorkSpaceRentUpdateCommand request, CancellationToken cancellationToken)
        {
            System.Guid Work_Space_ID = request.Work_Space_ID;
           string TIN = request.TIN;
            System.Guid? EAFW_ID = request.EAFW_ID;
            System.DateTime? Start_Date = request.Start_Date;
            System.DateTime? End_Date = request.End_Date;
            byte[] Contract_Doc = request.Contract_Doc;
            string EWSR_Status = request.EWSR_Status;
            bool? Is_Active = request.Is_Active;
            System.Guid? Parent = request.Parent;
            System.Double? Monthly_Price = request.Monthly_Price;
            IList<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN> result = await _procedureAdabter
                .Execute<EnterpriseWorkSpaceRent_WorkSpaceIDAndTIN>("[WorkSpace].proc_Enterprise_Work_Space_RentUpdate",
                    (nameof(Work_Space_ID), Work_Space_ID),
                    (nameof(TIN), TIN),
                    (nameof(EAFW_ID), EAFW_ID),
                    (nameof(Start_Date), Start_Date),
                    (nameof(End_Date), End_Date),
                    (nameof(Contract_Doc), Contract_Doc),
                    (nameof(EWSR_Status), EWSR_Status),
                    (nameof(Is_Active), Is_Active),
                    (nameof(Parent), Parent),
                     (nameof(Monthly_Price), Monthly_Price)
                    );
           

            return result;
        }
    }
}
 