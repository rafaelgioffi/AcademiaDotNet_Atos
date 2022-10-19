namespace Exercicios_Lista8.Exercicio6
{
    class Operador : Funcionario
    {        
            public Operador() { }
            public Operador(string nome, string departamento, double salario, string data, string rg, bool ativo) : base(nome, departamento, salario, data, rg, ativo) { }
        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Função: Operador");
            Console.WriteLine();
        }
    }

}
