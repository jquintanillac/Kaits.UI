using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaits.UI.Models.Entities
{
	[Table("Pedido")]
	public class PedidoEntity
	{
		[Key]
		public int Id_Orden { get; set; }
        public DateTime ord_fecha { get; set; }
        public int cod_cliente { get; set; }
        public decimal ord_precio_total { get; set; }
		public DateTime? fec_creacion { get; set; }
		public int? user_creacion { get; set; }
		public DateTime? fec_modificacion { get; set; }
	}
}
