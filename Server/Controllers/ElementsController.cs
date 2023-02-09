using ExamSalesApp.Server.BLL;
using ExamSalesApp.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExamSalesApp.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]	
	public class ElementsController : ControllerBase
	{
		private readonly IElementService _elementService;
		public ElementsController(IElementService elementService) {
			_elementService = elementService;
		}
		[HttpGet]
		[Route("api/elements/GetAsync")]
		public async Task<List<ElementsDto>> GetAsync()
		{
			return _elementService.GetList();
		}
		
		[HttpPost]
		[Route("api/elements/Post")]
		public void Post([FromBody] ElementsDto elements)
		{
			_ = _elementService.Create(elements);
		}

		[HttpPut]
		[Route("api/elements/Put")]
		public void Put([FromBody] ElementsDto elements)
		{

		}

		[HttpDelete]
		[Route("api/elements/Delete/{id}")]
		public void Delete(int id)
		{

		}
	}
}
