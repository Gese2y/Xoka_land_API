using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Tax;
using XOKA.Domain.Interfaces;

namespace Application.Tax.Commands.procEmployeeTINInfo.procEmployeeTINInfoDelete.procEmployeeTINInfoDeleteCommand
{

    /// @author  Shimels Alem  proc_Employee_TIN_InfoDelete stored procedure.


    public class procEmployeeTINInfoDeleteHandler : IRequestHandler<procEmployeeTINInfoDeleteCommand, IList<EmployeeTINInfo_EmpTINID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procEmployeeTINInfoDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployeeTINInfo_EmpTINID>> Handle( procEmployeeTINInfoDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<EmployeeTINInfo_EmpTINID> result = await _procedureAdabter
                .Execute<EmployeeTINInfo_EmpTINID>("[Tax].proc_Employee_TIN_InfoDelete", request);
           

            return result;
        }
    }
}
  