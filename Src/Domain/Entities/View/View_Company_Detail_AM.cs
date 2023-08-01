using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Company_Detail_AM
	{
		public string TIN { get; set; }
		public System.Guid ID { get; set; }
		public string COM_REG_Number { get; set; }
		public string Nationality { get; set; }
		public string GM_User { get; set; }
		public System.Guid? Region { get; set; }
		public System.Guid? Zone { get; set; }
		public string City { get; set; }
		public System.Guid? Sub_City { get; set; }
		public System.Guid? Woreda { get; set; }
		public string House_Number { get; set; }
		public string Email { get; set; }
		public string amharic_description { get; set; }
		public string name_am { get; set; }
		public bool? Is_Active { get; set; }


	}
}
