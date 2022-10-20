namespace Desafio1
{
    class Pessoa
    {
        private string _nome { get; set; }
        private string _telefone { get; set; }
        private string _cidade { get; set; }
        private string _rg { get; set; }
        private string _cpf { get; set; }

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Cidade = cidade;
            Rg = rg;
            Cpf = cpf;            
        }        

        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
    }
}
