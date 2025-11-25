using AmazonMGMT.Application.Interface;
using AmazonMGMT.Domain.Entity;
using AmazonMGMT.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDBContext _appdbcontext;

        public ProductService(AppDBContext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        
        public List<Product> GetProducts()
        {
            // var Products = _appdbcontext.Product.Include(p=>p.brand).ToList();

            var data = (from p in _appdbcontext.Product
                        join b in _appdbcontext.Brand
                        on p.BrandId equals b.BrandId
                        select new  Product  
                        {
                            ProductId= p.ProductId,
                            ProductName=p.ProductName,
                            BrandId=p.BrandId,
                            brand=b
                           

                        }).ToList();
            return data;
        }
    }
}
