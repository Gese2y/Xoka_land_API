using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Commands.procunEmployeeRequest.procunEmployeeRequestDelete.procunEmployeeRequestDeleteCommand
{

    /// @author  Shimels Alem  proc_unEmployeeRequestDelete stored procedure.


    public class procunEmployeeRequestDeleteHandler : IRequestHandler<procunEmployeeRequestDeleteCommand, IList<unEmployeeRequest_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procunEmployeeRequestDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<unEmployeeRequest_Id>> Handle( procunEmployeeRequestDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<unEmployeeRequest_Id> result = await _procedureAdabter
                .Execute<unEmployeeRequest_Id>("[UnEmployment].proc_unEmployeeRequestDelete", request);
           

            return result;
        }
    }
}
  