using System;
namespace Trabajopractico
{
    public class Tarea
    {
        
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recurso Responsable { get; set; }
        public bool Estado { get; set; }

        //public Tarea(string titulo, DateTime vencimiento, int estimacion, Recurso responsable, bool estado)
        //{
        //    Titulo = titulo;
        //    Vencimiento = vencimiento;
        //    Estimacion = estimacion;
        //    Responsable = responsable;
        //    Estado = estado;
        //}

        //public Tarea(string Titulo)
        //{
        //    this.Titulo = Titulo;
        //}
        //public Tarea()
        //{
        //}

        //public override string ToString()
        //{
        //    return "\nTitulo: " + Titulo + "\nVencimiento: " + Vencimiento
        //        + "\nEstimacion: " + Estimacion + "\nResponsable: " + Responsable + "\nEstado: " + Estado;
        //}
    }
}
