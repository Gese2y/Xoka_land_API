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

namespace Application.WorkSpace.Quiries.procEnterpriseWorkSpaceRent.GetprocEnterpriseWorkSpaceRentByTin
{
    public class GetprocEnterpriseWorkSpaceRentTinQueryHandler : IRequestHandler<GetprocEnterpriseWorkSpaceRentByTin, GetprocEnterpriseWorkSpaceRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEnterpriseWorkSpaceRentTinQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEnterpriseWorkSpaceRentLoadAllListVm> Handle(GetprocEnterpriseWorkSpaceRentByTin request, CancellationToken cancellationToken)
        {
           
            IList<EnterpriseWorkSpaceRent> procEnterpriseWorkSpaceRents = await _procedureAdabter
               .Execute<EnterpriseWorkSpaceRent>("[WorkSpace].[proc_Enterprise_Work_Space_RentLoadByTin]", request);
            GetprocEnterpriseWorkSpaceRentLoadAllListVm vm = new GetprocEnterpriseWorkSpaceRentLoadAllListVm
            {
                procEnterpriseWorkSpaceRents = _mapper.Map<IList<EnterpriseWorkSpaceRent>, IList<GetprocEnterpriseWorkSpaceRentLoadAllVm>>(procEnterpriseWorkSpaceRents)
            };

            return vm;
        }
    }
}
