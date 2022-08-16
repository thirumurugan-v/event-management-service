﻿using Event.API.DTOs.Category;
using Event.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Event.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        /// <summary>
        /// Gets the list of categories
        /// </summary>
        [Route("Get")]
        [HttpGet]
        [ProducesResponseType(typeof(CategoryDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<CategoryDto>>> GetCategoriesAsync()
        {
            var locations = await _categoryService.GetCategories();

            return Ok(locations);
        }
    }
}