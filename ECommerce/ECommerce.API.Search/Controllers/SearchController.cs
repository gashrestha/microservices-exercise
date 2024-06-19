using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.Versioning;
using ECommerce.API.Search.Interfaces;
using ECommerce.API.Search.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Search.Controllers
{
    [ApiVersion(1, Deprecated = true)]
    [ApiVersion(2)]
    [Route("api/v{v:apiVersion}/search")]
    [ApiController]
    public class SearchController(ISearchService searchService) : ControllerBase
    {
        private readonly ISearchService searchService = searchService;

        //Call this method from postman using a body parameter JSON Format like {"CustomerId": 1}
        //or using swagger ui : http://localhost:55455/index.html
        [MapToApiVersion(1)]
        [HttpPost]
        public async Task<IActionResult> SearchAsyncV1(SearchTerm term)
        {
            var result = await searchService.SearchAsync(term.CustomerId);
            if(result.IsSuccess)
            {
                return Ok(result.SearchResults);
            }
            return NotFound();
        }


        [MapToApiVersion(2)]
        [HttpPost]
        public async Task<IActionResult> SearchAsyncV2(SearchTerm term)
        {
            var result = await searchService.SearchAsync(term.CustomerId);
            if (result.IsSuccess)
            {
                return Ok(result.SearchResults);
            }
            return NotFound();
        }
    }
}
