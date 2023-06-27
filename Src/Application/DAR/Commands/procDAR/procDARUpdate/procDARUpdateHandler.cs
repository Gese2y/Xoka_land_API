

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.DAR;
using XOKA.Domain.Interfaces;

namespace Application.DAR.Commands.procDAR.procDARUpdate.procDARUpdateCommand
{

    /// @author  Shimels Alem  proc_DARUpdate stored procedure.


    public class procDARUpdateHandler : IRequestHandler<procDARUpdateCommand, IList<DAR_DARNO>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procDARUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<DAR_DARNO>> Handle( procDARUpdateCommand request, CancellationToken cancellationToken)
        {
            string DAR_NO = request.DAR_NO;
            string Name_EN = request.Name_EN;
            string Name_AM = request.Name_AM;
            string DAR_Type = request.DAR_Type;
            System.Guid? Doc_ID = request.Doc_ID;
            bool? IS_Signed = request.IS_Signed;
            System.Int32? No_of_Copy = request.No_of_Copy;
            string Parent = request.Parent;
            System.Guid? Licence_Id = request.Licence_Id;
            string Remark = request.Remark;
            System.Guid? Temp_Name_ID = request.Temp_Name_ID;
            string Ownership_Type = request.Ownership_Type;
            byte[] Scanned_Document = request.Scanned_Document;
            System.Int32? Number_Of_Pages = request.Number_Of_Pages;
            System.Double? Share_Price = request.Share_Price;
            IList<DAR_DARNO> result = await _procedureAdabter
                .Execute<DAR_DARNO>("[DAR].proc_DARUpdate", 
                (nameof(DAR_NO), DAR_NO),
               (nameof(Name_EN), Name_EN),
               (nameof(Name_AM), Name_AM),
               (nameof(DAR_Type), DAR_Type),
               (nameof(Doc_ID), Doc_ID),
               (nameof(IS_Signed), IS_Signed),
               (nameof(No_of_Copy), No_of_Copy),
               (nameof(Parent), Parent),
               (nameof(Licence_Id), Licence_Id),
               (nameof(Remark), Remark),
               (nameof(Temp_Name_ID), Temp_Name_ID),
               (nameof(Ownership_Type), Ownership_Type),
               (nameof(Scanned_Document), Scanned_Document),
               (nameof(Number_Of_Pages), Number_Of_Pages),
               (nameof(Share_Price), Share_Price)
           );
            return result;
        }
    }
}
 