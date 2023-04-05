



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procBussRelationInput.procBussRelationInputInsert.procBussRelationInputInsertCommand
{

    /// @author  Shimels Alem  proc_Buss_Relation_InputInsert stored procedure.


    public class procBussRelationInputInsertHandler : IRequestHandler<procBussRelationInputInsertCommand, IList<BussRelationInput_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBussRelationInputInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BussRelationInput_ID>> Handle( procBussRelationInputInsertCommand request, CancellationToken cancellationToken)
        {
            System.Guid ID = request.ID;
            System.Guid? Buyer_ID = request.Buyer_ID;
            System.Guid? Supplier = request.Supplier;
            byte[] Contract_DOC = request.Contract_DOC;
            System.DateTime? Date = request.Date;
            System.Double? Amount_Contract_Birr = request.Amount_Contract_Birr;
            System.DateTime? Expire_Date = request.Expire_Date;
            bool? Is_Active = request.Is_Active;
            string Remark = request.Remark;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            System.DateTime? Updated_Date = request.Updated_Date;
            IList<BussRelationInput_ID> result = await _procedureAdabter
                    .Execute<BussRelationInput_ID>("[Job].proc_Buss_Relation_InputInsert",
                    (nameof(ID), ID),
                    (nameof(Buyer_ID), Buyer_ID),
                    (nameof(Supplier), Supplier),
                    (nameof(Contract_DOC), Contract_DOC),
                    (nameof(Date), Date),
                    (nameof(Amount_Contract_Birr), Amount_Contract_Birr),
                    (nameof(Expire_Date), Expire_Date),
                    (nameof(Is_Active), Is_Active),
                    (nameof(Remark), Remark),
                    (nameof(Created_By), Created_By),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Updated_Date), Updated_Date)
                    );
           

            return result;
        }
    }
}
 