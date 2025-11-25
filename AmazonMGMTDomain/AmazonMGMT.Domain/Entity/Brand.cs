using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Domain.Entity
{
    public class Brand:BaseAuditEntity
    {
        public long BrandId {  get; set; }

        public string BrandName { get; set; }

        public string DisplayName { get; set; }

        public string Description { get; set; }
    }
}
