using Kaits.UI.IServices;
using Kaits.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kaits.UI.Apis
{
	[Route("api/[controller]")]
	[ApiController]
	public class APedidoController : ControllerBase
	{
		IPedido_services _pedidoService;
		public APedidoController(IPedido_services pedidoService)
		{
			_pedidoService = pedidoService;
		}

		// GET: api/<APedidoController>
		[HttpGet]
		public async Task<IEnumerable<VMPedidoGet>> GetAll()
		{
			return await _pedidoService.GetAllpedido();
		}

	
	}
}
