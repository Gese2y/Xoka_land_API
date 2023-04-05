

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsUpdate.procEnterpriseGradeRenewalDetailsUpdateCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationUpdate stored procedure.


    public class procEnterpriseGradeRenewalDetailsUpdateHandler : IRequestHandler<procEnterpriseGradeRenewalDetailsUpdateCommand, IList<Enterprise_Grade_Renewal_Details_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseGradeRenewalDetailsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }
        public async Task<IList<Enterprise_Grade_Renewal_Details_ID>> Handle(procEnterpriseGradeRenewalDetailsUpdateCommand request, CancellationToken cancellationToken)
        {

            System.Guid Ent_Grading_Detail_ID = request.Ent_Grading_Detail_ID;
            string TIN = request.TIN;
            string Code = request.Code;
            string Remarks = request.Remarks;
            System.DateTime? Date_Of_Grade_Issued = request.Date_Of_Grade_Issued;
            byte[] Grading_Letter = request.Grading_Letter;


            IList<Enterprise_Grade_Renewal_Details_ID> result = await _procedureAdabter
                    .Execute<Enterprise_Grade_Renewal_Details_ID>("[dbo].[proc_Enterprise_Grade_Renewal_DetailsUpdate]",
                        (nameof(Ent_Grading_Detail_ID), Ent_Grading_Detail_ID),
                        (nameof(TIN), TIN),
                        (nameof(Code), Code),
                        (nameof(Remarks), Remarks),
                        (nameof(Date_Of_Grade_Issued), Date_Of_Grade_Issued),
                        (nameof(Grading_Letter), Grading_Letter)
                        );

            return result;
        }
      
    }
}
 