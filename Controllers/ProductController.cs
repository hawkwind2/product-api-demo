using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Product_Kolmeo.Entities;
using Product_Kolmeo.Models;
using Product_Kolmeo.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product_Kolmeo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productServie;
        private readonly IMapper _mapper;

        public ProductController(IProductService productServie, IMapper mapper)
        {
            _productServie = productServie;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetProducts(int page = 0, int pageSize = 10)
        {
            var products = await _productServie.GetAll();
            var productModel = _mapper.Map<List<ProductModel>>(products);

            return Ok(productModel);
        }
        
        [HttpPost]
        public async Task AddProduct(ProductModel product)
        {
            var newProd =_mapper.Map<Product>(product);
            await _productServie.Add(newProd);
        }
    }
}