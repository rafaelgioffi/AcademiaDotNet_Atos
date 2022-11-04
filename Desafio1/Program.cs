using System.Drawing;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * DESAFIO #1
             * 
             * Passos:
             * Crie a classe Pessoa
             * Crie a classe Aluno
             * Outras classes se necessário
             * Aluno herda os atributos e métodos de Pessoa. Analise o manual do arquivo .txt
             * disponibilizado pelos professores para pensar nos métodos e atributos de
             * cada classe	Leia o arquivo .txt disponibilizado pelos professores Extraia os
             * dados do .txt e crie objetos destes dados
             * Mostre na tela, quantos objetos Pessoa e quantos Alunos foram criados.
             * Mostre os cursos de cada Aluno!
             * 
             * Manual do arquivo txt:
             * 
             * Geral:
             * “-“ é o caractere delimitador, ele separa os dados em uma mesma linha!
             * Cada linha tem um significado
             * A linha que começa com “X” é o cabeçalho, só informa que o arquivo é referente a 
             * Pessoas.	
             * A linha que começa com “Z” traz os dados dos alunos
             * A linha que começa com “Y”, é referente ao curso que a Pessoa esta cursando,
             * a linha “Y” vem sempre depois de uma linha “Z”,
             * logo, a linha “Y” é sobre o curso do Aluno(“Z”).
             * Nem sempre uma linha “Z” é seguida por uma linha “Y”, significa que é uma 
             * Pessoa cadastrada, e não um aluno. Logo, após uma linha “Z” aparece outra linha “Z”.
             * 
             * Linha X:
             * 
             * Cabeçalho do arquivo
             * Exemplo : X-4565-486544
             * Dica: Ignorar esta linha
             * 
             * Linha Z:
             * Traz dados das pessoas
             * Sintaxe: Z-[nome]-[telefone]-[cidade]-[RG]-[CPF]
             * 
             * Linha Y:
             * Traz dados da matricula do aluno (curso)
             * Sintaxe: Y-[matricula]-[código do curso]-[nome do curso]
             * */
            const string arq = "Database.txt";
            StreamReader sr = new StreamReader(arq);

            List<Pessoa> pessoa = new List<Pessoa>();
            List<Aluno> aluno = new List<Aluno>();

            int pessoas = pessoa.Count, alunos = aluno.Count;
            bool ehPessoa = false;
            string nome = "", telefone = "", cidade = "", rg = "", cpf = "", matricula = "", codigo = "", curso = "";

            do
            {
                string linha = sr.ReadLine();
                string[] filtro = linha.Split("-");
                string tipo = filtro[0];

                if (tipo == "X")
                {

                }
                else if (tipo == "Z")
                {
                    nome = filtro[1];
                    telefone = filtro[2];
                    cidade = filtro[3];
                    rg = filtro[4];
                    cpf = filtro[5];
                    pessoas++;
                    ehPessoa = true;
                }
                else if (tipo == "Y")
                {
                    if (ehPessoa)
                    {
                        pessoas--;
                        alunos++;
                    }
                    matricula = filtro[1];
                    codigo = filtro[2];
                    curso = filtro[3];
                    aluno.Add(new(nome, telefone, cidade, rg, cpf, matricula, codigo, curso));
                }
            } while (!sr.EndOfStream);

            sr.Close();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Pessoas: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(pessoas + "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"Alunos: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(alunos + "\n\n");

            foreach (var a in aluno)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Aluno: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(a.Nome);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  Curso: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(a.NomeCurso + "\n");
            }
            Console.ResetColor();
        }
    }
}