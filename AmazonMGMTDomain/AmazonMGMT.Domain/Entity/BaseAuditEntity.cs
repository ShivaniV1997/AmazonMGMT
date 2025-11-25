using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Domain.Entity
{
    public class BaseAuditEntity
    {
        public long CreatedBy {  get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsActive {  get; set; } 

        public long ModifiedBy { get; set; }

        public DateTime ModifiedOn {  get; set; }
    }
}
