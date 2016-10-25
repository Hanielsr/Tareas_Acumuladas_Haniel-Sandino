using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_Acumuladas
{
    class Tarea_4
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
            Tarea Corta 4
            Estudiante: [Haniel Sandino Rivera]

            Enunciado:
            Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
            La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
            Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
        */

        //Your code starts here

        public void Palindormo(String palabra)
        {
            String pal1 = palabra; // String donde vamos a guardar las palabras, palabra1, palabra2 y la palabra invertida.
            String pal2 = "", inversa = "";
            int i = 0, a = 0;//Contadores de cuantas letras tiene la palabra.

            a = pal1.Length;//Asignamos la cantidad de palabras que tiene la palabra ingresada.
            for (i = a - 1; i >= 0; i--)//Recorremos el indice de la palabra que es a, y lo vamos disminuyendo hasta que sea 0.
            {
                inversa = pal1.Substring(i, 1);//Almacenamos la palabra inversa en el String inversa letra por letra.
                pal2 = pal2 + inversa;//La vamos almacenando en la pal2, hasta completar la frase invertida.
            }

            Console.WriteLine("La palabra invertida es: " + pal2); //Imprimimos la palabra invertida.
            if (pal1.Equals(pal2))//Igualamos las palabras para ver si son iguales.
            {
                Console.WriteLine("La palabra es palindroma");//imprimimos si es palindroma o no.

            }
            else
            {
                Console.WriteLine("No es un palindromo");
            }
        }
    }
}
