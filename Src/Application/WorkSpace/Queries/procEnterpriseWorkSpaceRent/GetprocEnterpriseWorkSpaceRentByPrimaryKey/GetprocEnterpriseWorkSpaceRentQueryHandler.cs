using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentLoadAll;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentByPrimaryKey
{
    public class GetprocEnterpriseWorkSpaceRentQueryHandler : IRequestHandler<GetprocEnterpriseWorkSpaceRentByPrimaryKey, GetprocEnterpriseWorkSpaceRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnterpriseWorkSpaceRentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseWorkSpaceRentLoadAllListVm> Handle(GetprocEnterpriseWorkSpaceRentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EnterpriseWorkSpaceRent> procEnterpriseWorkSpaceRents = await _procedureAdabter
               .Execute<EnterpriseWorkSpaceRent>("[WorkSpace].[proc_Enterprise_Work_Space_RentLoadByPrimaryKey]", request);
            GetprocEnterpriseWorkSpaceRentLoadAllListVm vm = new GetprocEnterpriseWorkSpaceRentLoadAllListVm
            {
                procEnterpriseWorkSpaceRents = _mapper.Map<IList<EnterpriseWorkSpaceRent>, IList<GetprocEnterpriseWorkSpaceRentLoadAllVm>>(procEnterpriseWorkSpaceRents)
            };

            return vm;
        }
    }
}
