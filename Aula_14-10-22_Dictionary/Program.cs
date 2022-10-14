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

            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                { 1,"Banana"},
                { 2 ,"Laranja"},
                { 3 ,"Manga"},
                { 4 ,"Abacate"},
                { 5 ,"Maça"},
            };
            //foreach (KeyValuePair<int, string> item in dic1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.WriteLine(dic1[2]);
            //Console.WriteLine(dic1[4]);            
            //Console.ReadKey();
            string resultado;
            if (dic1.TryGetValue(4, out resultado))
            {
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Não foi possível achar a chave especificada.");
            }
        }
    }
}