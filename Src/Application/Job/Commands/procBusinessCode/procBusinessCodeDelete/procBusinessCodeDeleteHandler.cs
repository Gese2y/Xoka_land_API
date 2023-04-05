using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procBusinessCode.procBusinessCodeDelete.procBusinessCodeDeleteCommand
{

    /// @author  Shimels Alem  proc_Business_CodeDelete stored procedure.


    public class procBusinessCodeDeleteHandler : IRequestHandler<procBusinessCodeDeleteCommand, IList<BusinessCode_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBusinessCodeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BusinessCode_Code>> Handle( procBusinessCodeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BusinessCode_Code> result = await _procedureAdabter
                .Execute<BusinessCode_Code>("[Job].proc_Business_CodeDelete", request);
           

            return result;
        }
    }
}
  