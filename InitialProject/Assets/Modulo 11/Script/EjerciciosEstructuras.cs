using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Modulo_11.Script
{
    public class EjerciciosEstructuras : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //1)
            Debug.Log("--- Lista de Números Random ---");
            Debug.Log($"{string.Join(", ", GenerarListaRandomEnteros(10, 0, 40))}");

            //2)
            Debug.Log("--- Arreglo Ordenado de Enteros ---");
            var arregloDesordenado = new[] {4, 5, 1, 2, 3};
            Debug.Log($"[{string.Join(", ", OrdenarArregloEnteros(arregloDesordenado))}]");

            //3)
            Debug.Log("--- HashSet Sin Elementos Repetidos ---");
            var listaRepetida = new List<int> {1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5};
            Debug.Log($"{string.Join(", ", EliminarElementosRepetidos(listaRepetida))}");
            
            //4)
            var stack = new Stack<string>();
            stack.Push("Unity");
            stack.Push("De");
            stack.Push("Mundo");
            stack.Push("Hola");
            
            ImprimirValoresStack(stack);
        }

        //1)
        private List<int> GenerarListaRandomEnteros(int cantidad, int limiteInferior, int limiteSuperior)
        {
            var listaRandom = new List<int>();
            for (var i = 0; i < cantidad; i++)
            {
                listaRandom.Add(Random.Range(limiteInferior, limiteSuperior));
            }

            return listaRandom;
        }

        //2)
        private int[] OrdenarArregloEnteros(int[] arregloDesordenado)
        {
            return arregloDesordenado.OrderByDescending(i => i).ToArray();
        }

        //3)
        private HashSet<int> EliminarElementosRepetidos(List<int> listaRepetida)
        {
            return new HashSet<int>(listaRepetida.Distinct());
        }
        
        //4)
        private void ImprimirValoresStack(Stack<string> stackStrings)
        {
            var queueStrings = new Queue<string>();

            Debug.Log("--- Stack Original ---");
            Debug.Log($"{string.Join(", ", stackStrings)}");

            while (stackStrings.Count > 0)
            {
                queueStrings.Enqueue(stackStrings.Peek());
                stackStrings.Pop();
            }
            
            Debug.Log("--- Queue Generado ---");
            Debug.Log($"{string.Join(", ", queueStrings)}");
        }
    }
}