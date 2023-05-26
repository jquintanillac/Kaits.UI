using Kaits.UI.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kaits.UI.Models
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
        public DbSet<ClienteEntity> clientes { get; set; }
        public DbSet<ProdutosEntity> produtos { get; set; }
        public DbSet<PedidoEntity> pedidos { get; set; }
		public DbSet<Detalle_PedidoEntity> detalle_Pedidos { get; set; }
    }
}
