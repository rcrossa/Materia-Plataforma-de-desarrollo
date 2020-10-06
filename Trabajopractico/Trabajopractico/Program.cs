using System;
using System.Collections;
using System.Collections.Generic;

namespace Trabajopractico
{
    class Program
    {
        static void Main(string[] args)
        {

            //Usuario a = new Usuario();
            //Usuario b = new Usuario();
            //Usuario c = new Usuario();
            //Usuario d = new Usuario();
            //Recurso recurso = new Recurso("Pepe", a);
            //Recurso recurso1 = new Recurso("Carlos", b);
            //Recurso recurso2 = new Recurso("Ramon", d);
            //Recurso recurso3 = new Recurso("Luis", c);
            //Tarea tarea1 = new Tarea("Mi Primer Titulo");
            //Tarea tarea2 = new Tarea("Mi Segundo Titulo", DateTime.Today, 28, recurso1, true);
            //Tarea tarea3 = new Tarea("Mi Tercero Titulo", DateTime.Today, 20, recurso, false);
            //Tarea tarea4 = new Tarea("Mi Cuarto Titulo", DateTime.Today, 10, recurso, true);
            //ArrayList tareas = new ArrayList();
            //tareas.Add(tarea1);
            //tareas.Add(tarea2);
            //tareas.Add(tarea3);
            //tareas.Add(tarea4);


            //foreach (var item in tareas)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(tareas);

        }

        public static void Listas()
        {
            int[] numeros = new int[3];
            numeros[0] = 1;

            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add("");

            List<int> listadenumeros = new List<int>();
            listadenumeros.Add(1);


            Dictionary<int, String> personas = new Dictionary<int, string>();
            personas.Add(38, "Gabriel");

            Usuario a = new Usuario();
            Tarea tarea1 = new Tarea();
            Tarea tarea2 = new Tarea();
            Tarea tarea3 = new Tarea();
            Tarea tarea4 = new Tarea();
            ArrayList tareas = new ArrayList();
            tareas.Add(tarea1);
            tareas.Add(tarea2);
            tareas.Add(tarea3);
            tareas.Add(tarea4);

            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, };
            var test = num.Count;

        }

    }
}
