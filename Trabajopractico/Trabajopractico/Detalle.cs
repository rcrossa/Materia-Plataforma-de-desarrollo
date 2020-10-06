using System;
namespace Trabajopractico
{
    public class Detalle
    {
        public string Fecha { get; set; }
        public string Tiempo { get; set; }
        public Recurso Recurso { get; set; }
        public Tarea Tarea { get; set; }

        //public Detalle(string fecha, string tiempo, Recurso recurso, Tarea tarea)
        //{
        //    Fecha = fecha;
        //    Tiempo = tiempo;
        //    Recurso = recurso;
        //    Tarea = tarea;
        //}
    }
}
