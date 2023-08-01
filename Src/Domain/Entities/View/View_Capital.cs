using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Capital
    {

        public string TIN { get; set; }
        public System.Guid Capital_ID { get; set; }
        public string COM_REG_Number { get; set; }
        public System.Double Intaial_Capital { get; set; }
        public System.Double? Current_Capital { get; set; }
        public string Year { get; set; }
        public System.DateTime? Updated_Date { get; set; }
        public bool? Is_Active { get; set; }

    }
}
