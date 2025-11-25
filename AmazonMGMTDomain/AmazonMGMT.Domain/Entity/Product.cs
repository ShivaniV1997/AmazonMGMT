using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Domain.Entity
{
    public class Product:BaseAuditEntity
    {
        public int ProductId {  get; set; }

        public string ProductName { get; set; }= string.Empty;

        public string ProductDescription { get; set; }

        public long BrandId {  get; set; }

        public Brand brand { get; set; }
    }
}
