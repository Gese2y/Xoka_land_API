


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Job;

namespace Application.Job.Commands.procOrganization.procOrganizationInsert.procOrganizationInsertCommand
{

    /// @author  Shimels Alem  proc_AssetsInsert stored procedure.


    public class procOrganizationInsertCommand : IRequest<IList<Organization_ID>>
    {
        public System.Guid organization_code { get; set; }
        public string Registration_code { get; set; }
        public Nullable<System.Guid> organization_Type_code { get; set; }
        public string name_en { get; set; }
        public string name_local { get; set; }
        public string name_am { get; set; }
        public string name_or { get; set; }
        public string name_tg { get; set; }
        public string description_am { get; set; }
        public string description_en { get; set; }
        public string description_or { get; set; }
        public string description_tg { get; set; }
        public string email { get; set; }
        public string POBox { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string PhysicalAddress { get; set; }
        public Nullable<decimal> ZoomLevel { get; set; }
        public byte[] header { get; set; }
        public byte[] footer { get; set; }
        public Nullable<decimal> geo_location_X { get; set; }
        public Nullable<decimal> geo_location_Y { get; set; }
        public string organization_link { get; set; }
        public string organization_help_id { get; set; }
        public Nullable<System.Guid> created_by { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<bool> is_published { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<bool> is_serviceOwner { get; set; }
        public Nullable<System.Guid> ref_languages_lanaguage_code { get; set; }
        public Nullable<System.Guid> organizations_organization_code { get; set; }
        public Nullable<bool> is_synched { get; set; }
        public Nullable<System.DateTime> date_synched { get; set; }
        public string Database_IP { get; set; }
        public string WebServer_IP { get; set; }
        public string GISServerService_URL { get; set; }
        public string GISServerService_UserName { get; set; }
        public string GISServerService_Password { get; set; }
    }
		
		
		 
}
 
 