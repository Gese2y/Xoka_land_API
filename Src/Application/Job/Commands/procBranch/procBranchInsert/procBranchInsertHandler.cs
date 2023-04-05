



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;


namespace Application.Job.Commands.procBranch.procBranchInsert.procBranchInsertCommand
{

    /// @author  Shimels Alem  proc_BranchInsert stored procedure.


    public class procBranchInsertHandler : IRequestHandler<procBranchInsertCommand, IList<Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBranchInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Branch_ID>> Handle( procBranchInsertCommand request, CancellationToken cancellationToken)
        {
             System.Guid ID = request.ID;
             byte[]? Address = request.Address;
             string Type = request.Type;
             string Product = request.Product;
             IList<Branch_ID> result = await _procedureAdabter
                    .Execute<Branch_ID>("[Job].proc_BranchInsert",
                    (nameof(ID), ID),
                    (nameof(Address), Address),
                    (nameof(Type), Type),
                    (nameof(Product), Product)
                    );
           

                return result;
        }
    }
}
 