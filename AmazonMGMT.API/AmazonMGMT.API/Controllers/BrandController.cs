using AmazonMGMT.Application.Interface;
using AmazonMGMT.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazonMGMT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private IBrandServices _brandServices;

        public BrandController(IBrandServices brandServices)
        {
            _brandServices = brandServices;
        }

        [HttpGet("GetBrands")]
        public ActionResult GetAllBrands()
        {
            return Ok(_brandServices.GetBrands());
        }

        [HttpPost("Create")]
        public ActionResult Create(Brand brand)
        {
            return Ok(_brandServices.Create(brand));
        }

        [HttpGet("getById/{brandId}")]
        public ActionResult GetById(long brandId)
        {
            return Ok(_brandServices.GetById(brandId));
        }

        [HttpPut]
        public ActionResult Update(Brand brand)
        {           
                return Ok(_brandServices.Update(brand));
           
        }
    }
}
