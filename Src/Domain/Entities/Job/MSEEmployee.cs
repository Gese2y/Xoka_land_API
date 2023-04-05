using System;

namespace XOKA.Domain.Entities.Job
{
    public class MSEEmployee
	{
		public System.Guid ID { get; set; }
		public string MSE_TIN { get; set; }
		public string Employee_TIN { get; set; }
		public string Full_Name { get; set; }
		public string Gender { get; set; }
		public System.DateTime? Date_of_Birth { get; set; }
		public decimal? Basic_Salary { get; set; }
		public string mse_emplyee_status { get; set; }

		public string Education_Level { get; set; }
		public bool Is_Disabled { get; set; }
		public bool Is_Refugee { get; set; }
		public bool Is_Returnee { get; set; }
		public bool Has_HIV { get; set; }
		public string Kebele_ID { get; set; }

	}
}
