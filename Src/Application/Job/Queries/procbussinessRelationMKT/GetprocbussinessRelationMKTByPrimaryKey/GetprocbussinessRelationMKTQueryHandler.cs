using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Job.Quiries.procbussinessRelationMKT.GetprocbussinessRelationMKTLoadAll;
using XOKA.Domain.Entities.Job;
using XOKA.Domain.Interfaces;

namespace Application.Job.Quiries.procbussinessRelationMKT.GetprocbussinessRelationMKTByPrimaryKey
{
    public class GetprocbussinessRelationMKTQueryHandler : IRequestHandler<GetprocbussinessRelationMKTByPrimaryKey, GetprocbussinessRelationMKTLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocbussinessRelationMKTQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocbussinessRelationMKTLoadAllListVm> Handle(GetprocbussinessRelationMKTByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<bussinessRelationMKT> procbussinessRelationMKTs = await _procedureAdabter
               .Execute<bussinessRelationMKT>("[Job].[proc_bussiness_Relation_MKTLoadByPrimaryKey]", request);
            GetprocbussinessRelationMKTLoadAllListVm vm = new GetprocbussinessRelationMKTLoadAllListVm
            {
                procbussinessRelationMKTs = _mapper.Map<IList<bussinessRelationMKT>, IList<GetprocbussinessRelationMKTLoadAllVm>>(procbussinessRelationMKTs)
            };

            return vm;
        }
    }
}
