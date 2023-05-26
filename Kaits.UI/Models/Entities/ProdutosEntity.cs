using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaits.UI.Models.Entities
{
	[Table("Productos")]
	public class ProdutosEntity
	{
		[Key]
		public int cod_producto { get; set; }
        public string prod_descripcion { get; set; }
		public DateTime? fec_creacion { get; set; }
		public int? user_creacion { get; set; }
		public DateTime? fec_modificacion { get; set; }
	}
}
