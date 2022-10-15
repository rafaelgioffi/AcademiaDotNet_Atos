using System.Collections.Generic;

namespace Aula_14_10_22_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IDictionary<int, string> dic1 = new Dictionary<int, string>();
            //dic1.Add(1, "Maria");
            //dic1.Add(2, "Paulo");
            //dic1.Add(3, "Pedro");

            //Dictionary<int, string> dic1 = new Dictionary<int, string>()
            //{
            //    { 1,"Banana"},
            //    { 2 ,"Laranja"},
            //    { 3 ,"Manga"},
            //    { 4 ,"Abacate"},
            //    { 5 ,"Maça"},
            //};
            //foreach (KeyValuePair<int, string> item in dic1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.WriteLine(dic1[2]);
            //Console.WriteLine(dic1[4]);            
            //Console.ReadKey();

            //string resultado;
            //if (dic1.TryGetValue(4, out resultado))
            //{
            //    Console.WriteLine(resultado);
            //}
            //else
            //{
            //    Console.WriteLine("Não foi possível achar a chave especificada.");
            //}

            //Console.WriteLine(dic1.ContainsKey(1));
            //Console.WriteLine(dic1.ContainsKey(6));

            //Console.WriteLine(dic1.ContainsValue("Manga"));

            //Console.ReadLine();

            //dic1.Remove(2);
            //Console.WriteLine("Atualização: \n");
            //foreach (KeyValuePair<int, string> item in dic1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //string fruta;
            //dic1.Remove(3, out fruta);
            //Console.WriteLine(fruta + " removida");
            //Console.WriteLine("Atualização 2: \n");
            //foreach (KeyValuePair<int, string> item in dic1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            SortedDictionary<string, int> dic1 = new SortedDictionary<string, int>();
            //Add strings e chaves
            dic1.Add("zebra", 5);
            dic1.Add("cachorro", 2);
            dic1.Add("gato", 9);
            dic1.Add("pardal", 4);
            dic1.Add("C#", 100);

            //verifica se o gato existe...
            if (dic1.ContainsKey("gato"))
            {
                Console.WriteLine("tem um gato ai...");
            }
            //verifica se tem zebra
            if (dic1.ContainsKey("zebra"))
            {
                Console.WriteLine("Deu zebra pois tem uma zebra ai...");
            }
            //verifica se contém C#
            // e se tiver peg ao valor
            int v;
            if (dic1.TryGetValue("C#", out v))
            {
                Console.WriteLine(v);
            }

            //imprime o SortedDictionary em ordem alfabética
            foreach (KeyValuePair<string, int> p in dic1)
            {
                Console.WriteLine(p.Key + " " + p.Value);
            }
        }
    }
}