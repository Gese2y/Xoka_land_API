using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procEnterprise_Grade_Points_Details.procEnterprise_Grade_Points_DetailsDelete.procEnterprise_Grade_Points_DetailsDeleteCommand
{

    /// @author  Shimels Alem  proc_Enterprise_RegistrationDelete stored procedure.


    public class procEnterprise_Grade_Points_DetailsDeleteHandler : IRequestHandler<procEnterprise_Grade_Points_DetailsDeleteCommand, IList<Enterprise_Grade_Points_Details_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEnterprise_Grade_Points_DetailsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Enterprise_Grade_Points_Details_ID>> Handle(procEnterprise_Grade_Points_DetailsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Enterprise_Grade_Points_Details_ID> result = await _procedureAdabter
                .Execute<Enterprise_Grade_Points_Details_ID>("[dbo].proc_Enterprise_Grade_Points_DetailsDelete", request);
           

            return result;
        }
    }
}
  