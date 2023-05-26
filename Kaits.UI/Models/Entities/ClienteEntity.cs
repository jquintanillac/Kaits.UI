using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kaits.UI.Models.Entities
{
	[Table("Clientes")]
	public class ClienteEntity
	{
		[Key]
        public int cod_cliente { get; set; }
        public string clie_nomb { get; set; }
        public string clie_apell { get; set; }
        public string clie_dociden { get; set; }
        public DateTime? fec_creacion { get; set; }
        public int? user_creacion { get; set; }
        public DateTime? fec_modificacion { get; set; }
    }
}
