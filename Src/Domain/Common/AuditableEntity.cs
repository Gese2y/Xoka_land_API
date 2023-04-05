using System;

namespace Domain.Common
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }

        public System.DateTime Created { get; set; }

        public string LastModifiedBy { get; set; }

        public System.DateTime? LastModified { get; set; }
    }
}
