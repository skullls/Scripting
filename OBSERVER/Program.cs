namespace Observador
{
    using System;
    using System.Collections.Generic;

    // Interfaz IObserver
    public interface IObserver
    {
        void Actualizar(string mensaje);
    }

     // Clase Subject
    public class Subject
    {
        private List<IObserver> _observadores = new List<IObserver>();
        private string _estado;

        public void Suscribir(IObserver observador) => _observadores.Add(observador);
        public void Desuscribir(IObserver observador) => _observadores.Remove(observador);

        public void CambiarEstado(string nuevoEstado)
        {
            _estado = nuevoEstado;
            Notificar();
        }

         private void Notificar()
        {
            foreach (var observador in _observadores)
                observador.Actualizar(_estado);
        }

    }

    // Clase concreta que implementa IObserver
    public class ObservadorConcreto : IObserver
    {
        private string _nombre;

        public ObservadorConcreto(string nombre) => _nombre = nombre;

        public void Actualizar(string mensaje) => Console.WriteLine($"{_nombre} ha recibido: {mensaje}");
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            ObservadorConcreto observador1 = new ObservadorConcreto("Observador 1");
            ObservadorConcreto observador2 = new ObservadorConcreto("Observador 2");

            subject.Suscribir(observador1);
            subject.Suscribir(observador2);

            subject.CambiarEstado("Nuevo estado 1");
            subject.CambiarEstado("Nuevo estado 2");
        }
    }

