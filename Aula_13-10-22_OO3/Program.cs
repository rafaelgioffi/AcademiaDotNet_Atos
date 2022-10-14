namespace Aula_13_10_22_OO3
{
    class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(40, "Ricardo"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
            //Console.ReadKey();
            Console.WriteLine("\nLista não ordenada:");
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });

            Console.WriteLine("\nLista ordenada por nome:");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
            
            Console.WriteLine("\nLista ordenada por idade:");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Idade.CompareTo(p2.Idade);
            });
            pessoas.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            });
            
            Console.WriteLine("\nInserindo uma pessoa na posição 1 e outra na posição 3");
            pessoas.Insert(1, new Pessoa() { Nome = "Bob Dylan", Idade = 78 });
            pessoas.Insert(3, new Pessoa() { Nome = "Jimi Page", Idade = 81 });
            
            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Idade + " " + p.Nome);
            }

            Console.WriteLine("\n========\n");

            //pessoas com idade menor que 45...
            List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa p) { return p.Idade < 45; });

            Console.WriteLine("Pessoas com menos de 45 anos: ");
            jovem.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
        }
    }
}