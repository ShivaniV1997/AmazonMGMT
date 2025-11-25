using AmazonMGMT.Application.Interface;
using AmazonMGMT.Domain.Entity;
using AmazonMGMT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Application.Services
{
    public class BrandServices : IBrandServices
    {
        private readonly AppDBContext _appDBContext;

        public BrandServices(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public List<Brand> GetBrands()
        {
            var brands = _appDBContext.Brand.Where(b=>b.IsActive==true).ToList();  
            return brands;
        }

       public int Create(Brand brand)
        {
           
            brand.CreatedBy = 1;
            brand.CreatedOn = DateTime.Now;
            brand.ModifiedBy = 1;
            brand.ModifiedOn = DateTime.Now;
            _appDBContext.Add(brand);
            var result=_appDBContext.SaveChanges();
            return result;
        }

        public Brand GetById(long brandId)
        {
            var brand = _appDBContext.Brand.Find(brandId);
            return brand;
        }

        public int Update(Brand brandDTO)
        {
            //var brands = _appDBContext.Brand.Update(brand);
            var brands = _appDBContext.Brand.Find(brandDTO.BrandId);
            if(brands == null) 
                return 0;
            brands.BrandName = brandDTO.BrandName;
            brands.DisplayName = brandDTO.BrandName;
            brands.Description = brandDTO.Description;
            brands.IsActive = brandDTO.IsActive;
            brands.ModifiedBy = 1;
            brands.ModifiedOn = DateTime.Now;

            _appDBContext.Update(brands);
            var result = _appDBContext.SaveChanges();
            return result;
        }
    }
}
