using Kaits.UI.IServices;
using Kaits.UI.Models;
using Kaits.UI.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Kaits.UI.Services
{
	public class Pedido_services : IPedido_services
	{
		DataContext _context;
		public Pedido_services(DataContext context)
		{
			_context = context;
		}
		public string Delete(int Id_Orden)
		{
			throw new NotImplementedException();
		}

		public async Task<List<VMPedidoGet>> GetAllpedido()
		{
			var vmpeditotal = await(from pedidos in _context.pedidos
								  join cliente in _context.clientes on  pedidos.cod_cliente equals cliente.cod_cliente
								  select new VMPedidoGet
								  {
									  Id_Orden = pedidos.Id_Orden,
									  ord_fecha = pedidos.ord_fecha,
									  clie_nomb = cliente.clie_nomb + " " + cliente.clie_apell,
									  ord_precio_total = pedidos.ord_precio_total									
								  }).ToListAsync();
			return vmpeditotal;
		}
	}
}
