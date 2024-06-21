using Portafolio.Models;

namespace Portafolio.Servicios
{
	public class RepositorioProyectos : IRepositorioProyectos
	{
		public List<Proyectos> ObtenerProyectos()
		{
			return new List<Proyectos>() {
				new Proyectos
			{
				Titulo = "Amazon",
				Descripcion = "E-Commerce realizado en ASP.NET Core",
				Link = "https://amazon.com",
				ImagenURL =  "/imagenes/amazon.png"
			},
				new Proyectos
			{
				Titulo = "Pagina de noticias",
				Descripcion = "Página de noticias",
				Link = "https://lun.cl",
				ImagenURL =  "/imagenes/lun.png"
			},
				new Proyectos
			{
				Titulo = "Steam",
				Descripcion = "E-Commerce realizado en ASP.NET Core",
				Link = "https://store.steampowered.com",
				ImagenURL =  "/imagenes/steam.jpeg"
			}
			};
		}
	}
}
