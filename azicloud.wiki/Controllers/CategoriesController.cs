using azicloud.wiki.Dtos;
using azicloud.wiki.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace azicloud.wiki.Controllers
{
    [Route("api/v1/wiki/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IWikiCategoryService _wikiCategory;
        public CategoriesController(IWikiCategoryService wikiCategory)
        {
            _wikiCategory = wikiCategory;
        }

        [HttpGet("list")]
        public async Task<IActionResult> Filter_Rows1()
        {
            return Ok( await _wikiCategory.Filter_Rows1());
        }

        [HttpPost("insert_update")]
        public async Task<IActionResult> Create1(PostWikiCategoryDto req)
        {
            return Ok(await _wikiCategory.Create1(req));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete1(long intId, long uId)
        {
            return Ok(await _wikiCategory.Delete1(intId, uId));
        }
    }
}
