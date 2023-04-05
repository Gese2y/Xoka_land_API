using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.UnEmployment;
using XOKA.Domain.Interfaces;

namespace Application.UnEmployment.Commands.procUnEmployee.procUnEmployeeDelete.procUnEmployeeDeleteCommand
{

    /// @author  Shimels Alem  proc_UnEmployeeDelete stored procedure.


    public class procUnEmployeeDeleteHandler : IRequestHandler<procUnEmployeeDeleteCommand, IList<UnEmployee_TIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procUnEmployeeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<UnEmployee_TIN>> Handle( procUnEmployeeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<UnEmployee_TIN> result = await _procedureAdabter
                .Execute<UnEmployee_TIN>("[UnEmployment].proc_UnEmployeeDelete", request);
           

            return result;
        }
    }
}
  