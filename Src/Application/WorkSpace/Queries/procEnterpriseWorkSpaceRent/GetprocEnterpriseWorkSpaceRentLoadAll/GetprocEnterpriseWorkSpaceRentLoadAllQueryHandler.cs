using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.WorkSpace;
using XOKA.Domain.Interfaces;

namespace Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentLoadAll
{
    class GetprocEnterpriseWorkSpaceRentLoadAllQueryHandler : IRequestHandler<GetprocEnterpriseWorkSpaceRentLoadAllQuery, GetprocEnterpriseWorkSpaceRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEnterpriseWorkSpaceRentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseWorkSpaceRentLoadAllListVm> Handle(GetprocEnterpriseWorkSpaceRentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EnterpriseWorkSpaceRent> procEnterpriseWorkSpaceRents = await _procedureAdabter
               .Execute<EnterpriseWorkSpaceRent>("[WorkSpace].[proc_Enterprise_Work_Space_RentLoadAll]");
            GetprocEnterpriseWorkSpaceRentLoadAllListVm vm = new GetprocEnterpriseWorkSpaceRentLoadAllListVm
            {
                procEnterpriseWorkSpaceRents = _mapper.Map<IList<EnterpriseWorkSpaceRent>, IList<GetprocEnterpriseWorkSpaceRentLoadAllVm>>(procEnterpriseWorkSpaceRents)
            };

            return vm;
        }
    }
}
