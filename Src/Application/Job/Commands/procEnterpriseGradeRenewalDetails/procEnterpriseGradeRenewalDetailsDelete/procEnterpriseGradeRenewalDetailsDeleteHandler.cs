using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseGradeRenewalDetails.procEnterpriseGradeRenewalDetailsDelete.procEnterpriseGradeRenewalDetailsDeleteCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.


    public class procEnterpriseGradeRenewalDetailsDeleteHandler : IRequestHandler<procEnterpriseGradeRenewalDetailsDeleteCommand, IList<Enterprise_Grade_Renewal_Details_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseGradeRenewalDetailsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Enterprise_Grade_Renewal_Details_ID>> Handle(procEnterpriseGradeRenewalDetailsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Enterprise_Grade_Renewal_Details_ID> result = await _procedureAdabter
                .Execute<Enterprise_Grade_Renewal_Details_ID>("[dbo].proc_Enterprise_Grade_Renewal_DetailsDelete", request);
           

            return result;
        }
    }
}
  