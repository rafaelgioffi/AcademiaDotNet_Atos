namespace Exercicios_Lista7.Exercicio6
{
    public class Agenda
    {
        public List<Pessoa> pessoa = new List<Pessoa>();

        public void armazenaPessoa(string nome, int idade, float altura)
        {
            pessoa.Add(new(nome, idade, altura));
            Console.Clear();
            Console.WriteLine("'{0}' cadastrado!\n", nome);
            
        }

        public void removePessoa(String nome)
        {
            Pessoa p = buscaPessoa(nome);
            Console.Clear();
            pessoa.Remove(p);
            Console.WriteLine("'{0}' removido(a).\n", p.nome);
        }

        public Pessoa buscaPessoa(String nome)
        {
            Pessoa p = null;
            foreach (Pessoa pes in pessoa)
            {
                if (pes.nome.Equals(nome))
                {
                    p = pes;
                }
            }
            return p;
        }
        public void imprimeAgenda()
        {
            Console.Clear();
            foreach (var p in pessoa)
            {
                Console.WriteLine("Nome: {0}", p.nome);
                Console.WriteLine("Idade: {0} anos", p.idade);
                Console.WriteLine("Altura: {0}m\n", p.altura);
            }
        }

    }
}
