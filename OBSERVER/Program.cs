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

    }

