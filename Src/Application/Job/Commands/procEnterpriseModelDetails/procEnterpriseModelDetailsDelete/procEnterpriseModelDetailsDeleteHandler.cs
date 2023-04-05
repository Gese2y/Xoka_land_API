using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterpriseModelDetails.procEnterpriseModelDetailsDelete.procEnterpriseModelDetailsDeleteCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.


    public class procEnterpriseModelDetailsDeleteHandler : IRequestHandler<procEnterpriseModelDetailsDeleteCommand, IList<Enterprise_Model_Details_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterpriseModelDetailsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Enterprise_Model_Details_ID>> Handle( procEnterpriseModelDetailsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Enterprise_Model_Details_ID> result = await _procedureAdabter
                .Execute<Enterprise_Model_Details_ID>("[dbo].proc_Enterprise_Model_DetailsDelete", request);
           

            return result;
        }
    }
}
  