using Kaits.UI.Models.Entities;

namespace Kaits.UI.Models.ViewModels
{
	public class VMPedido
	{
        public PedidoEntity? oPedidocab { get; set; }
        public List<Detalle_PedidoEntity>? oDetalle_Pedidos { get; set; }
    }
}
