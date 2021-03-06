﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_Acumuladas
{
    using System.Collections.Generic;
    class Tarea_1
    {
        /*
        Tarea Corta
        Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
        desarrollen su logica de programacion y logica matematica.
        Cada tarea tendra un id, el metodo de entrega sera el siguiente:
        1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
        2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
        3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
        4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
        5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
        6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
        7. De existir otras soluciones, especificar porque no se utilizaron.
        8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
        */

        /*
            Tarea Corta 1
            Estudiante: [Haniel Sandino Rivera]

            Enunciado:
            Escriba una funcion que retorne el elemento mas grande de una lista no ordenada	
        */

        //Your code starts here
       
        public int NumeroGrande(List<int> numero)
        {
            int mayor = 0;// asigne una variable integer.
            for (int i = 0; i < numero.Count; i++)//for que recorre el arreglo
            {
                if (numero[i] > mayor)//if que valida si el numero del arreglo es mayor a la variable mayor.
                {
                    mayor = numero[i];//almacena el numero mayor del arreglo
                }
            }
            return mayor;
        }
    }
}
