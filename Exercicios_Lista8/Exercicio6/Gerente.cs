namespace Exercicios_Lista8.Exercicio6
{
    class Gerente : Funcionario
    {
        public Gerente() { }
        public Gerente(string nome, string departamento, double salario, string data, string rg, bool ativo) : base(nome, departamento, salario, data, rg, ativo) { }
        public override void ExecutaTrabalho()
        {        
            Console.WriteLine("Função: Gerente");
        }

        //Henrique
        /*
         * class Gerente : Funcionario
        {
        public Gerente() { }
        public Gerente(string nome, string depto, string dataCriacao, string rg, double salario, bool ativo) : base(nome, depto, dataCriacao, rg, salario, ativo) { }

        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Desempenha a função de Gerente.");
        */

    }
}
