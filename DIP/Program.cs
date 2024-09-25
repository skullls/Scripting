namespace DIP
{
    // Interfaz INotificacion
    public interface INotificacion
    {
        void Enviar(string mensaje);
    }

    // Clase concreta de CorreoElectronico
    public class CorreoElectronico : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Correo enviado: {mensaje}");
        }
    }

    // Clase concreta de SMS
    public class SMS : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"SMS enviado: {mensaje}");
        }
    }

    // Clase ControladorDeNotificaciones (alto nivel)
    public class ControladorDeNotificaciones
    {
        private INotificacion _notificacion;

        public ControladorDeNotificaciones(INotificacion notificacion)
        {
            _notificacion = notificacion;
        }

        public void Notificar(string mensaje)
        {
            _notificacion.Enviar(mensaje);
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            INotificacion correo = new CorreoElectronico();
            INotificacion sms = new SMS();

            ControladorDeNotificaciones controlador = new ControladorDeNotificaciones(correo);
            controlador.Notificar("Bienvenido por correo.");

            controlador = new ControladorDeNotificaciones(sms);
            controlador.Notificar("Bienvenido por SMS.");
        }
    }

}
