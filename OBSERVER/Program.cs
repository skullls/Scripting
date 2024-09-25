namespace Observador
{
    using System;
    using System.Collections.Generic;

    // Interfaz IObserver
    public interface IObserver
    {
        void Actualizar(string mensaje);
    }
