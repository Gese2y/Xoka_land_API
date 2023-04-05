

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procTINERCA.procTINERCAUpdate.procTINERCAUpdateCommand
{

    /// @author  Shimels Alem  proc_TIN_ERCAUpdate stored procedure.


    public class procTINERCAUpdateHandler : IRequestHandler<procTINERCAUpdateCommand, IList<TINERCA_TIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTINERCAUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TINERCA_TIN>> Handle( procTINERCAUpdateCommand request, CancellationToken cancellationToken)
        {
            string TIN = request.TIN;
            string DAR_NO = request.DAR_NO;
            System.DateTime? Date_Regstered = request.Date_Regstered;
            string TIN_Type = request.TIN_Type;
            string Company_Name = request.Company_Name;
            string Tax_Center = request.Tax_Center;
            System.Guid? ORG_ID = request.ORG_ID;
            string Status = request.Status;
            System.Guid? Created_By = request.Created_By;
            System.Guid? Updated_By = request.Updated_By;
            byte[] Date_log = request.Date_log;
            System.Guid? Licence_ID = request.Licence_ID;
            IList<TINERCA_TIN> result = await _procedureAdabter
                .Execute<TINERCA_TIN>("[Tax].proc_TIN_ERCAUpdate", 
                    (nameof(TIN), TIN),
                    (nameof(Date_Regstered), Date_Regstered),
                    (nameof(TIN_Type), TIN_Type),
                    (nameof(ORG_ID), ORG_ID),
                    (nameof(Status), Status),
                    (nameof(Created_By), Created_By),
                    (nameof(Updated_By), Updated_By),
                    (nameof(Date_log), Date_log),
                    (nameof(Licence_ID), Licence_ID),
                    (nameof(Company_Name), Company_Name),
                     (nameof(Tax_Center), Tax_Center),
                     (nameof(DAR_NO), DAR_NO)
                    );
           

            return result;
        }
    }
}
 