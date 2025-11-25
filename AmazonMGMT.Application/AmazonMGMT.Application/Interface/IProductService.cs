using AmazonMGMT.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Application.Interface
{
    public interface IProductService
    {
        List<Product> GetProducts();


    }
}
