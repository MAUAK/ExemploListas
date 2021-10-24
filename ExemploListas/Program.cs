using System;
using System.Collections.Generic;

namespace ExemploListas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // ================ KAUAM SILVA BATISTA - 210501 ================= 
            
            //Criando a lista de strings
            List<string> list = new List<string>();

            //Adicionando elementos na lista
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("Andre");

            //Adicionando um elemento na posição sugerida
            list.Insert(2, "Lucas");

            //Realizando um loop de leitura dos elementos inseridos
            foreach (string obj in list)
            {
                Console.WriteLine(obj);

                //Econtrar o elemento que inicia com a letra A
                //string s1 = list.Find(Test);
            }

            /*static bool Test (string s)
             {
                    return s[0] == 'A';
             }*/

            //Contando qunatos elementos tem na minha lista
            Console.WriteLine("\nQuantidade de elementos na Lista: " + list.Count);

            //Econtrar o elemento que inicia com a letra A com uma função lambda
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\nPrimeiro elemento com a letra A: " + s1);

            //Econtrar o elemento que inicia com a letra A com uma função lambda
            string s2 = list.FindLast(y => y[0] == 'A');
            Console.WriteLine("Último elemento com a letra A: " + s2);

            //Buscando elementos pela sua posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nPrimeira posição de A: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição de A: " + pos2);

            //Buscando todos os elemento com tamanho igual a 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("\n-----------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Removendo elementos da lista
            list.Remove("Andre");
            Console.WriteLine("\n================");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover determinado elemento da lista
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("\n+++++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elemento de determinada posição da lista
            list.RemoveAt(3);
            Console.WriteLine("\nXXXXXXXXXXXXXXXXXXXXXXX");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remover elementos da lista a partir da posição e qunatos elementos
            list.RemoveRange(1, 2);
            Console.WriteLine("\n.........................");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
