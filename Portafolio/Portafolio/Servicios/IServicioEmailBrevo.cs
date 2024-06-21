using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IServicioEmailBrevo
    {
        Task Enviar(Contacto contacto);
    }
}
