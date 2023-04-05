



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procEnterpriseModelDetails.procEnterpriseModelDetailsInsert.procEnterpriseModelDetailsInsertCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationInsert stored procedure.


    public class procEnterpriseModelDetailsInsertHandler : IRequestHandler<procEnterpriseModelDetailsInsertCommand, IList<Enterprise_Model_Details_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseModelDetailsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

		public async Task<IList<Enterprise_Model_Details_ID>> Handle(procEnterpriseModelDetailsInsertCommand request, CancellationToken cancellationToken)
		{

			System.Guid Ent_Model_Detail_ID = request.Ent_Model_Detail_ID;
			string TIN = request.TIN;
			Nullable<double> Point_Earned = request.Point_Earned;
			string Remarks = request.Remarks;
			System.DateTime? Date_Of_Model_Selection = request.Date_Of_Model_Selection;
			byte[] Model_Evaluation_Letter = request.Model_Evaluation_Letter;


			IList<Enterprise_Model_Details_ID> result = await _procedureAdabter
					.Execute<Enterprise_Model_Details_ID>("[dbo].[proc_Enterprise_Model_DetailsInsert]",
						(nameof(Ent_Model_Detail_ID), Ent_Model_Detail_ID),
						(nameof(TIN), TIN),
						(nameof(Point_Earned), Point_Earned),
						(nameof(Remarks), Remarks),
						(nameof(Date_Of_Model_Selection), Date_Of_Model_Selection),
						(nameof(Model_Evaluation_Letter), Model_Evaluation_Letter)
						);

			return result;
		}
		
    }
}
 