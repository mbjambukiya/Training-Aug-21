using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GetSkilled.DtoClasses;
using GetSkilled.Entities;
using GetSkilled.Models;
using GetSkilled.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetSkilled.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = UserRoles.Admin)]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _category;
        private readonly IMapper _mapper;
        public CategoryController(ICategory category, IMapper mapper)
        {
            _category = category;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCategoryList()
        {
            try
            {

                var result = _category.GetAllData();
                var categoryList = new List<CategoryDto>();
                foreach (var i in result)
                {
                    if (i.IsDeleted == false)
                    {
                        var category = _mapper.Map<CategoryDto>(i);
                        categoryList.Add(category);
                    }
                }
                if (categoryList.Any())
                {
                    return Ok(categoryList);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{categoryId}")]
        public IActionResult GetCategoryById(int categoryId)
        {
            try
            {
                var result = _category.GetDataById(categoryId);

                if (result != null && result.IsDeleted == false)
                {
                    var category = _mapper.Map<CategoryDto>(result);
                    return Ok(category);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            try
            {
                category.LastModified = DateTime.Now;
                var result = _category.CreateData(category);
                if (result == true)
                {
                    _category.SaveData();
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut()]
        public IActionResult UpdateCategory(Category category)
        {
            try
            {
                category.LastModified = DateTime.Now;
                if (category.IsDeleted == false)
                {
                    var result = _category.UpdateData(category);
                    if (result == true)
                    {
                        _category.SaveData();
                        return Ok(result);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete("{categoryId}")]
        public IActionResult DeleteCategory(int categoryId)
        {
            try
            {
                var result = _category.DeleteData(categoryId);
                if (result == true)
                {
                    _category.SaveData();
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
