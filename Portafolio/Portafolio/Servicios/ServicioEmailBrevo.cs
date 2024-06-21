using Portafolio.Models;
using System.Net;
using System.Net.Mail;

namespace Portafolio.Servicios
{
    public class ServicioEmailBrevo : IServicioEmailBrevo
    {
        private readonly IConfiguration _configuration;

        public ServicioEmailBrevo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task Enviar(Contacto contacto)
        {
            var email = _configuration.GetValue<string>("SMTP_FROM");
            var nombre = _configuration.GetValue<string>("SMTP_NOMBRE");
            var password = _configuration.GetValue<string>("SMTP_PASSWORD");
            var host = "smtp.gmail.com";
            var port = 587;

            if(string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(nameof(email), "La direccion de correo electronico 'from no puede ser nula o vacia'");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(password), "La contraseña no puede ser nula o vacia");
            }

            var from = new MailAddress(email, nombre);
            var subject = $"El cleinte {contacto.Email} quiere contactarte";
            var to = new MailAddress(email, nombre);
            var mensajeTextoPlano = contacto.Mensaje;
            var contenidoHtml = $@"De: {contacto.Nombre} - Email: {contacto.Email} Mensaje: {contacto.Mensaje}";

            using (var client = new SmtpClient(host, port))
            {
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(email,password);

                using(var message = new MailMessage(from, to))
                {
                    message.Subject = subject;
                    message.Body = contenidoHtml;
                    message.IsBodyHtml = true;

                    await client.SendMailAsync(message);
                }
            }
        }
    }
}
