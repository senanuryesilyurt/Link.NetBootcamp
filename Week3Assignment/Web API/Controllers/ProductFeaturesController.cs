using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Abstract;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeaturesController : ControllerBase
    {
        private readonly IProductFeatureService _productFeatureService;

        public ProductFeaturesController(IProductFeatureService productFeatureService)
        {
            _productFeatureService = productFeatureService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result =  _productFeatureService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost]
        public IActionResult Add(ProductFeature productFeature)
        {
            var result =  _productFeatureService.Add(productFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete]
        public IActionResult Delete(ProductFeature productFeature)
        {
            var result = _productFeatureService.Delete(productFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut]
        public IActionResult Update(ProductFeature productFeature)
        {
            var result = _productFeatureService.Update(productFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
