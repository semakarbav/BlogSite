using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _categoryService.GetList();
            return Ok(result);
        }
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            return Ok(result);
        }
    }
}
