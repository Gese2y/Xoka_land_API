using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Commands.procbussinessRelationMKT.procbussinessRelationMKTDelete.procbussinessRelationMKTDeleteCommand
{

    /// @author  Shimels Alem  proc_bussiness_Relation_MKTDelete stored procedure.


    public class procbussinessRelationMKTDeleteHandler : IRequestHandler<procbussinessRelationMKTDeleteCommand, IList<bussinessRelationMKT_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procbussinessRelationMKTDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<bussinessRelationMKT_ID>> Handle( procbussinessRelationMKTDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<bussinessRelationMKT_ID> result = await _procedureAdabter
                .Execute<bussinessRelationMKT_ID>("[Job].proc_bussiness_Relation_MKTDelete", request);
           

            return result;
        }
    }
}
  