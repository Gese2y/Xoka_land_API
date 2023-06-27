



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsInsert.procEnterprise_Grade_Points_DetailsInsertCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


    public class procEnterprise_Grade_Points_DetailsInsertHandler : IRequestHandler<procEnterprise_Grade_Points_DetailsInsertCommand, IList<Enterprise_Grade_Points_Details_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterprise_Grade_Points_DetailsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }
        public async Task<IList<Enterprise_Grade_Points_Details_ID>> Handle(procEnterprise_Grade_Points_DetailsInsertCommand request, CancellationToken cancellationToken)
        {
                string ID = request.ID;
            System.DateTime? Date_Graded = request.Date_Graded;
            string Filled_By = request.Filled_By;
            string JSON_Value = request.JSON_Value;
        string Enterprise_TIN = request.Enterprise_TIN;


            IList<Enterprise_Grade_Points_Details_ID> result = await _procedureAdabter
                    .Execute<Enterprise_Grade_Points_Details_ID>("[dbo].[proc_Enterprise_Grade_Points_DetailsInsert]",
                        (nameof(ID), ID),
                        (nameof(Date_Graded), Date_Graded),
                        (nameof(Filled_By), Filled_By),
                        (nameof(JSON_Value), JSON_Value),
                        (nameof(Enterprise_TIN), Enterprise_TIN)
                        );

            return result;
        }
       
    }
}
 