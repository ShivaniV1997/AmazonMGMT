using AmazonMGMT.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMGMT.Application.Interface
{
    public interface IBrandServices
    {
        List<Brand> GetBrands();

        int Create(Brand brand);

        Brand GetById(long brandId);

        int Update(Brand brand);
    }
}
