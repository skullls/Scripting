namespace Observador
{
    using System;
    using System.Collections.Generic;

    // Interfaz IObserver
    public interface IObserver
    {
        void Actualizar(string mensaje); // este metodo sera llamado por el Subject para notificar cambios
    }

     // Clase Subject: maneja el estado y notifica a los observadores cuando hay cambios
    public class Subject
    {
        private List<IObserver> _observadores = new List<IObserver>(); // lista de observadores suscritos
        private string _estado; // estado del Subject
        
        public void Suscribir(IObserver observador) => _observadores.Add(observador); // metodo para suscribir observadores
        public void Desuscribir(IObserver observador) => _observadores.Remove(observador); // mwtodo para desuscribir observadores

        // cambia el estado del Subject y notifica a los observadores
        public void CambiarEstado(string nuevoEstado)
        {
            _estado = nuevoEstado;
            Notificar();
        }

        // notifica a todos los observadores suscritos sobre el cambio de estado
         private void Notificar()
        {
            foreach (var observador in _observadores)
                observador.Actualizar(_estado);
        }

    }

    // Clase concreta que implementa IObserver
    public class ObservadorConcreto : IObserver
    {
        private string _nombre;  // nombre del observador

        public ObservadorConcreto(string nombre) => _nombre = nombre;  // constructor que asigna el nombre al observador

        public void Actualizar(string mensaje) => Console.WriteLine($"{_nombre} ha recibido: {mensaje}");  // se llama al metodo Actualizar cuando el estado del Subject cambia
    } 

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // creacion instancia subject
            Subject subject = new Subject();
            // creacion de dos observadores
            ObservadorConcreto observador1 = new ObservadorConcreto("Observador 1");
            ObservadorConcreto observador2 = new ObservadorConcreto("Observador 2");

            //suscripcion observadores
            subject.Suscribir(observador1);
            subject.Suscribir(observador2);

            // cambio de estados
            subject.CambiarEstado("Nuevo estado 1");
            subject.CambiarEstado("Nuevo estado 2");
        }
    }

