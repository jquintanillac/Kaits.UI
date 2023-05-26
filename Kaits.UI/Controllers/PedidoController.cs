using Kaits.UI.Models;
using Kaits.UI.Models.Entities;
using Kaits.UI.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Kaits.UI.Controllers
{
	public class PedidoController : Controller
	{
		DataContext _context;		

		public PedidoController(DataContext context)
		{
			_context = context;		
		}

		// GET: PedidoController
		public async Task<ActionResult> Index()
		{
			ViewBag.cliente = await _context.clientes.ToListAsync();
			ViewBag.producto = await _context.produtos.ToListAsync();
			return View();
		}

		[HttpPost]
		public IActionResult PagoPedido([FromBody] VMPedido oPedido)
		{
			bool respuesta = false;
			DateTime fecrea = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");

			PedidoEntity oPedcab = new PedidoEntity
			{
				ord_fecha = oPedido.oPedidocab.ord_fecha,
				cod_cliente = oPedido.oPedidocab.cod_cliente,
				ord_precio_total = oPedido.oPedidocab.ord_precio_total,
				fec_creacion = fecrea

			};
			_context.pedidos.Add(oPedcab);
			_context.SaveChanges();
			var idPedido = _context.pedidos.OrderByDescending(t => t.Id_Orden).FirstOrDefault();

			VMPedido oPedidosDet = new VMPedido();
			oPedidosDet.oDetalle_Pedidos = oPedido.oDetalle_Pedidos;

			foreach (var item in oPedido.oDetalle_Pedidos.ToList())
			{
				Detalle_PedidoEntity oDetalle = new Detalle_PedidoEntity
				{
					Id_Orden = idPedido.Id_Orden,
					cod_producto = item.cod_producto,
					desc_producto = item.desc_producto,
					detped_cantidad = item.detped_cantidad,
					detped_precunit = item.detped_precunit,
					detped_subtotal = item.detped_subtotal,
					fec_creacion = fecrea
				};
				_context.detalle_Pedidos.Add(oDetalle);
				_context.SaveChanges();
			}

			return Json(new { respuesta });
		}
	
	}
}
