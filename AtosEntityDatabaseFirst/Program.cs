using Microsoft.EntityFrameworkCore;

namespace AtosEntityDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite:\n" +
                "1 - Criar uma pessoa\n" +
                "2 - Alterar nome da Pessoa\n" +
                "3 - Inserir um e-mail\n" +
                "4 - Excluir uma Pessoa\n" +
                "5 - Consultar Tudo\n" +
                "6 - Consultar Pessoa pelo ID\n\n" +
                "Opção: ");
            int op = int.Parse(Console.ReadLine());

            AtosEntity2Context contexto = new AtosEntity2Context();

            switch (op)
            {
                case 1:
                    Console.Clear();
                    try
                    {
                        Console.Write("Inserir o nome da pessoa: ");
                        Pessoa p = new Pessoa();
                        p.nome = Console.ReadLine();

                        Console.Write("Inserir o e-mail: ");
                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Pessoa cadastrada com sucesso!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    Console.Clear();
                    try
                    {
                        Console.Write("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);
                        Console.Clear();
                        Console.Write("Informe o novo nome da pessoa: ");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                case 3:
                    Console.Clear();
                    try
                    {
                        Console.Write("Informe o ID da pessoa: ");
                        int idEm = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Pessoa pEm = contexto.Pessoas.Find(idEm);

                        Console.Write($"Informe o novo E-mail do(a) {pEm.nome}: ");
                        string emailTemp = Console.ReadLine();

                        pEm.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Update(pEm);
                        contexto.SaveChanges();

                        Console.WriteLine("E-mail inserido com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.Write("Informe o ID da pessoa: ");
                        int idEx = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(idEx);

                        Console.Write($"Tem certeza que deseja excluir o(a) {p.nome}?");
                        Console.Write("E seus e-mails: ");
                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine($"    {item.email}");
                        }

                        Console.WriteLine("1 - Sim");
                        Console.WriteLine("2 ou qualquer outra tecla - Não");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine($"{p.nome} excluído com sucesso!");
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        List<Pessoa> lista = (from Pessoa p in contexto.Pessoas
                                              select p).Include(pes => pes.Emails).ToList<Pessoa>();

                        foreach (Pessoa p in lista)
                        {
                            Console.Write(p.nome);

                            foreach (Email em in p.Emails)
                            {
                                Console.Write("\t" + em.email);
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.Write("Informe o ID da pessoa: ");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.Emails)
                            .FirstOrDefault(Pessoa => Pessoa.Id == id);

                        Console.WriteLine($"Nome: {p.nome}");
                        if (p.Emails != null)
                        {
                            foreach (Email item in p.Emails)
                            {
                                Console.WriteLine($"\t{item.email}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    break;
                default:
                    break;
            }
        }
    }
}