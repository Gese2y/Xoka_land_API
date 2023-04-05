
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procMSEwarning.procMSEwarningUpdate.procMSEwarningUpdateCommand

{ 

	/// @author  Shimels Alem  proc_Renew_Info_ChangeInsert stored procedure.


	public class procMSEwarningUpdateHandler : IRequestHandler<procMSEwarningUpdateCommand, IList<MSEwarning_ID>>
	{
		readonly IMapper _mapper;
		readonly IProcedureAdabter _procedureAdabter;
		public procMSEwarningUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
		{
			_mapper = mapper;
			_procedureAdabter = procedureAdabter;
		}

		public async Task<IList<MSEwarning_ID>> Handle(procMSEwarningUpdateCommand request, CancellationToken cancellationToken)
		{

			System.Guid ID = request.ID;
			string TIN = request.TIN;
			string Warning_Code = request.Warning_Code;
			string Description = request.Description;
			System.DateTime? Date_Issued = request.Date_Issued;
			string Status = request.Status;
			byte[] Warning_Letter_Doc = request.Warning_Letter_Doc;


			IList<MSEwarning_ID> result = await _procedureAdabter
					.Execute<MSEwarning_ID>("[dbo].[proc_Enterprise_WarningUpdate]",
						(nameof(ID), ID),
						(nameof(TIN), TIN),
						(nameof(Warning_Code), Warning_Code),
						(nameof(Description), Description),
						(nameof(Date_Issued), Date_Issued),
						(nameof(Status), Status),
						(nameof(Warning_Letter_Doc), Warning_Letter_Doc)
						);

			return result;
		}
	}

}
