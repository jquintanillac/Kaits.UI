using Kaits.UI.Models.ViewModels;

namespace Kaits.UI.IServices
{
	public interface IPedido_services
	{
		Task<List<VMPedidoGet>> GetAllpedido();	
	}
}
