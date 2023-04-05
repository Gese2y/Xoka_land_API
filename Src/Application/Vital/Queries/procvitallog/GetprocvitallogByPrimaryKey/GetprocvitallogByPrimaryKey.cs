using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vital.Quiries.procvitallog.GetprocvitallogLoadAll;

namespace Application.Vital.Quiries.procvitallog.GetprocvitallogByPrimaryKey
{
    /// @author  Shimels Alem proc_Vital_EventsLoadByPrimaryKey stored procedure.

    public class GetprocvitallogByPrimaryKey : IRequest<GetprocvitallogLoadAllListVm>
    {
        public string Kebele_ID { get; set; }
    }
}
