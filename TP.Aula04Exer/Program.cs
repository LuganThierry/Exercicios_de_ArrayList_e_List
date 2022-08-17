using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace TP.Aula04Exer
{
    internal static class Program
    {
        static void Main(string[] args)
        {

            // -------------------------------------------------------------------------

            // EXERCÍCIO 1 COM ARRAYLIST

            Console.WriteLine("EXERCÍCIO 1 DE ARRAYLIST");

            static void numeroIgual(ArrayList numeros, int numero)
            {
                ArrayList arrayIndex = new ArrayList();

                if (!numeros.Contains(numero))
                {
                    Console.WriteLine($"O número {numero} não está na lista");
                }

                for (int i = 0; i < numeros.Count; i++)
                {
                    if (numeros.Contains(numero))
                    {
                        arrayIndex.Add(numeros.IndexOf(numero) + i);
                        numeros.RemoveAt(numeros.IndexOf(numero));
                    }
                }


                for (int j = 0; j < arrayIndex.Count; j++)
                {
                    Console.WriteLine(arrayIndex[j]);
                }
            }


            ArrayList testearraylist = new ArrayList() { 8, 0, 5, 5, 10, 22, 5};
            int testeint = 2;

            numeroIgual(testearraylist, testeint);


            // -------------------------------------------------------------------------

            // EXERCÍCIO 1 COM LIST

            Console.WriteLine("EXERCÍCIO 1 DE LIST");

            List<int> lista = new List<int>() { 1, 2, 3, 10, -4, -5, -23 };

            int contagemPositivos = 0;
            int somaNegativos = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > 0)
                {
                    contagemPositivos++;
                }

                else if (lista[i] < 0)
                {
                    somaNegativos += lista[i];
                }
            }

            Console.WriteLine(contagemPositivos);
            Console.WriteLine(somaNegativos);

            // -------------------------------------------------------------------------

            // EXERCÍCIO 2 COM LIST 

            Console.WriteLine("EXERCÍCIO 2 DE LIST");

            List<int> lista2 = new List<int>() { 1, 2, 3, 10, -4, -5, -23 };

            int maiorValor = lista2.AsQueryable().Max();
            int menorValor = lista2.AsQueryable().Min();


            if (lista2.Count == 1 || lista2.Count == 0)
            {
                Console.WriteLine(0);
            }

            else
            {
                Console.WriteLine(maiorValor - menorValor);
            }

            // -------------------------------------------------------------------------

            // EXERCÍCIO 3 COM LIST


            Console.WriteLine("EXERCÍCIO 3 DE LIST");

            List<int> lista3 = new List<int>() { 2, -3, 15, 0 };

            List<int> proximoZero = new List<int>();


            for (int i = 0; i < lista3.Count; i++)
            {
                proximoZero.Add(Math.Abs(lista3[i]));
            }

            proximoZero.Sort();

            if (proximoZero[0] == proximoZero[1])
            {
                Console.WriteLine("Nenhum");
            }

            else
            {
                Console.Write(proximoZero[0]);
            }


            // -------------------------------------------------------------------------


        }

    }

}
