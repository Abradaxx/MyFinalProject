using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Attribute 
    public class ProductsController : ControllerBase
    {
        //Loosely Coupled
        //naming convention
        //Javascriptte ctor a direk verildiğinde aşağıda erişebiliriz ama burada erişmek için
        //ctor öncesi field oluşturup reference we are gonna take to ours referecne

        //IoC Container----> Inversion of Control
        //   
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swager
            //Dependency Chain var burada
            var result= _productService.GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]//
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Succes == true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
 