namespace Colecoes
{
    class Pessoa : IComparable
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateOnly DataNascimento { get; set; }
        public Pessoa(string nome, string cPF, DateOnly dataNascimento)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + ". CPF: " + CPF + ". Data Nascimento: " + DataNascimento;
        }
        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa && CPF == pessoa.CPF;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, CPF);
        }
        public int CompareTo(object? obj)
        {
            Pessoa p = (Pessoa)obj;
            if (this.Nome == p.Nome)
            {
                return 0;
            }
            else if (this.Nome.CompareTo(p.Nome) < 0)
            {
                return -1;
            }
            return 1;
        }

    }
}