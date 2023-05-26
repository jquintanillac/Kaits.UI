using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaits.UI.Models.Entities
{
	[Table("Detalle_Pedido")]
	public class Detalle_PedidoEntity
	{
		[Key]
		public int Id_detped { get; set; }
		public int Id_Orden { get; set; }
		public int cod_producto { get; set; }
        public string desc_producto { get; set; }
        public int detped_cantidad { get; set; }
        public decimal detped_precunit { get; set; }
        public decimal detped_subtotal { get; set; }
		public DateTime? fec_creacion { get; set; }
		public int? user_creacion { get; set; }
		public DateTime? fec_modificacion { get; set; }
	}
}
