using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        class Rifa
        {
            public bool Sair { get; set; }

            public void RegistrarVenda(ref string[] nomes, ref long[] telefones, ref char[] status)
            {
                int posição;
                string Nome;
                long Telefone;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome: ");
                    Nome = Console.ReadLine();
                } while (Nome == null);

                do
                {
                    Console.WriteLine("Digite o Telefone: ");
                    Telefone = long.Parse(Console.ReadLine());
                } while (Telefone == 1);

                do
                {
                    Console.WriteLine("Digite o Nº onde deseja armazenar os dados: ");
                    posição = int.Parse(Console.ReadLine());
                } while (posição < 1 || posição > 50);

                if (status[posição - 1] == 'D')
                {
                    Console.Clear();
                    Console.WriteLine("Verificando posição da Rifa...");
                    status[posição - 1] = 'I';
                    nomes[posição - 1] = Nome;
                    telefones[posição - 1] = Telefone;
                    Console.WriteLine("Atribuição concluída.");
                    Console.WriteLine("Pressione uma tecla para continuar. . .");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Erro! Esta posição já está ocupada ou você ultrapassou os limites da Rifa.");
                    Console.WriteLine("Pressione uma tecla para continuar. . .");
                    Console.ReadKey();
                }
            }

            public void ConsultarBilhete(ref string[] nomes, ref char[] status, ref long[] telefones)
            {
                int NumeroRifa;
                string BuscarNome;
                int ContadorNomes = 0;
                int opc;
                Console.Clear();
                Console.WriteLine("Digite qual o tipo de Consulta.");
                Console.WriteLine("[1] Por Nome. \n[2] Pelo N° do bilhete. \n[3] Mostrar todos os bilhetes. \n \n[0] Voltar ao Menu Principal.");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    Console.Clear();
                    Console.Write("Digite o nome para ser buscado: ");
                    BuscarNome = Console.ReadLine();
                    for (int i = 0; i <= 49; i++)
                    {
                        if (BuscarNome == nomes[i])
                        {
                            ContadorNomes++;
                        }
                    }
                    Console.WriteLine("Foram encontradas {0} rifas com o nome {1}.", ContadorNomes, BuscarNome);
                    Console.ReadKey();
                }
                else if (opc == 2)
                {
                    Console.Clear();
                    Console.Write("Digite o Nº do bilhete para ser buscado: ");
                    NumeroRifa = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("O bilhete Nº{0} contém os seguintes dados", NumeroRifa);
                    Console.WriteLine("\n Status: {0}", status[NumeroRifa - 1]);
                    Console.WriteLine("\n Nome: {0}", nomes[NumeroRifa - 1]);
                    Console.WriteLine("\n Telefone: {0}", telefones[NumeroRifa - 1]);
                }
                else if (opc == 3)
                {
                    Console.Clear();
                    Console.WriteLine("[3] Mostrar todos bilhetes da Rifa.");
                    Console.WriteLine("\n D- Disponível \n I - Indisponível");
                    Console.WriteLine();
                    #region
                    int i = 0;
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}       ", i + 1);
                        i++;
                    }
                    i = 0;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 0;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 0;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    /////////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}       ", i + 1);
                        i++;
                    }
                    i = 5;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 5;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 5;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ////////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 10;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 10;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 10;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 15;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 15;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 15;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 20;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 20;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 20;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 25;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 25;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 25;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 30;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 30;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 30;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 35;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 35;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 35;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 40;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 40;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 40;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    Console.WriteLine("\n");
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Bilhete N° {0}      ", i + 1);
                        i++;
                    }
                    i = 45;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Status: {0}          ", status[i]);
                        i++;
                    }
                    i = 45;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Nome: {0}             ", nomes[i]);
                        i++;
                    }
                    i = 45;
                    Console.WriteLine();
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("Telefone: {0}        ", telefones[i]);
                        i++;
                    }
                    ///////////////////////////////
                    #endregion
                }
                Console.WriteLine("\n");
                Console.WriteLine("\nDigite qualquer tecla para voltar ao Menu. . .");
                Console.ReadKey();
            }

            public void AlterarRifa(ref string[] nomes, ref char[] status, ref long[] telefones)
            {
                int nrifa;
                int op;
                char atrib;
                do
                {
                    Console.Clear();
                    Console.Write("Digite o Nº da Rifa que deseja alterar: ");
                    nrifa = int.Parse(Console.ReadLine());
                    if (status[nrifa - 1] == 'D')
                    {
                        Console.WriteLine("Erro! Essa Rifa ainda não foi comprada.");
                    }
                    else
                    {
                        Console.WriteLine("Certo! Carregando. . .");
                    }
                } while (nrifa < 1 || nrifa > 50 || nrifa - 1 == 'D');
                nrifa--;
                Console.Clear();
                Console.WriteLine(" Bilhete Nº {0}", nrifa + 1);
                Console.WriteLine(" Nome: {0}", nomes[nrifa]);
                Console.WriteLine(" Telefone: {0}", telefones[nrifa]);
                Console.WriteLine("");
                Console.WriteLine("Escolha o campo do bilhete Nº {0} da Rifa que desejas editar", nrifa + 1);
                Console.WriteLine("");
                Console.WriteLine("[1] Nome\t[2] Telefone\t[3] Ambos.");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o novo nome a ser atribuido: ");
                        string NovoNome = Console.ReadLine();
                        Console.WriteLine("Tem certeza que deseja atribuir >> {0} << para o campo Nome? (S/N)", NovoNome);
                        atrib = char.Parse(Console.ReadLine().ToUpper());
                        if (atrib == 'S')
                        {
                            Console.WriteLine("");
                            nomes[nrifa] = NovoNome;
                            Console.WriteLine("Alteração realizada com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para ver as alterações. . .");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(" Bilhete Nº {0}", nrifa + 1);
                            Console.WriteLine(" Nome: {0}", nomes[nrifa]);
                            Console.WriteLine(" Telefone: {0}", telefones[nrifa]);
                            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Alteração não confirmada.");
                            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite o novo telefone a ser atribuido: ");
                        long NovoTel = long.Parse(Console.ReadLine());
                        Console.WriteLine("Tem certeza que deseja atribuir >> {0} << para o campo Telefone? (S/N)", NovoTel);
                        atrib = char.Parse(Console.ReadLine().ToUpper());
                        if (atrib == 'S')
                        {
                            Console.WriteLine("");
                            telefones[nrifa] = NovoTel;
                            Console.WriteLine("Alteração realizada com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para ver as alterações. . .");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(" Bilhete Nº {0}", nrifa + 1);
                            Console.WriteLine(" Nome: {0}", nomes[nrifa]);
                            Console.WriteLine(" Telefone: {0}", telefones[nrifa]);
                            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Alteração não confirmada.");
                            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        Console.Write("Digite o novo nome: ");
                        NovoNome = Console.ReadLine();
                        Console.Write("Digite o novo telefone: ");
                        NovoTel = long.Parse(Console.ReadLine());
                        Console.WriteLine("Atribuir >> {0} << para Nome", NovoNome);
                        Console.WriteLine("Atribuir >> {0} << para Telefone? (S/N)", NovoTel);
                        atrib = char.Parse(Console.ReadLine().ToUpper());
                        if (atrib == 'S')
                        {
                            Console.WriteLine("");
                            nomes[nrifa] = NovoNome;
                            telefones[nrifa] = NovoTel;
                            Console.WriteLine("Alteração realizada com sucesso!");
                            Console.WriteLine("Pressione qualquer tecla para ver as alterações. . .");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(" Bilhete Nº {0}", nrifa + 1);
                            Console.WriteLine(" Nome: {0}", nomes[nrifa]);
                            Console.WriteLine(" Telefone: {0}", telefones[nrifa]);
                            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Alteração não confirmada.");
                            Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        break;
                }
            }

            public void ExcluirRifa(ref string[] nomes, ref char[] status, ref long[] telefones)
            {
                int erifa;
                do
                {
                    Console.Clear();
                    Console.Write("Digite o Nº da Rifa que deseja apagar: ");
                    erifa = int.Parse(Console.ReadLine());
                } while (erifa < 1 || erifa > 50);
                int i = erifa - 1;
                status[i] = 'D';
                nomes[i] = "";
                telefones[i] = 0;
                Console.WriteLine("Pronto! Dados apagados com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                Console.ReadKey();
            }

            public void GerarRelatorio(ref char[] status)
            {
                int disp = 0;
                int indisp = 0;
                for (int i = 0; i <=49; i++)
                {
                    if (status[i] == 'D')
                    {
                        disp++;
                    }
                    else
                    {
                        indisp++;
                    }
                }
                Console.Clear();
                Console.WriteLine("Gerando relatório das rifas. . .");
                Console.WriteLine();
                Console.WriteLine("Rifas disponíveis: {0}%", (disp * 100) / 50 );
                Console.WriteLine("Rifas indisponíveis: {0}%", (indisp * 100) / 50);
                Console.WriteLine();
                if ( indisp == 0)
                {
                    Console.WriteLine("Que pena! Nenhum dos bilhetes foi vendido ainda.");
                    Console.WriteLine("Tente vender para amigos e familiares, tenho certeza que vai conseguir :)");
                }
                else
                if ( indisp == 1)
                {
                    Console.WriteLine("Sortear uma rifa com apenas bilhete vendido, não me parece uma ideia muito sábia");
                    Console.WriteLine("Conquiste mais emoção para este sorteio, venda bilhetes para outras pessoas.");
                }
                else
                    if ( indisp == 2)
                {
                    Console.WriteLine("Tenha foco! Vá até o seu grupo de amigos e divulgue a venda dos bilhetes.");
                    Console.WriteLine("Eu acredito no seu potencial.");
                }
                else
                {
                    Console.WriteLine("Agora sim, um número de bilhetes vendidos digno para esta Rifa.");
                    Console.WriteLine("Tá esperando o que pra realizar o sorteio dos bilhetes?");
                }
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar. . .");
                Console.ReadKey();
            }

            public void Sortear(ref string[] nomes, ref char[] status, ref long[] telefones)
            {
                int op = 0;
                int i;
                int contarifas = 0;
                for (i = 0; i <= 49; i++)
                {
                    if (status[i] == 'I')
                    {
                        contarifas++;
                    }
                    else
                    {
                        //Não faz nada.
                    }
                }

                Console.Clear();
                if (contarifas == 0)
                {
                    Console.WriteLine("Impossivel realizar sorteios, número minimo de rifas compradas tem que maior que zero.");
                    Console.WriteLine("Pressione uma tecla para continuar. . .");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("\n R E A L I Z A N D O   S O R T E I O");
                    Thread.Sleep(2000);
                    Console.WriteLine("\n Vou até me segurar aqui. . .");
                    Thread.Sleep(2000);
                    Random rnd = new Random();
                    do {
                        int nsorte = rnd.Next(0, 50);

                        i = nsorte;
                    }
                    while (status[i] == 'D');

                    Console.WriteLine("\n Óhhhhhhh!!");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine("O GANHADOR DO SORTEIO DA RIFA FOI {0} com o bilhete Nº {1}", nomes[i], i);
                    Console.WriteLine();
                    Console.WriteLine("ENTRE EM CONTATO COM O GANHADOR PELO TELEFONE: {0}", telefones[i]);
                    Console.WriteLine("Pressione uma tecla para continuar. . .");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Agora que ja temos um vencedor");
                    Console.WriteLine("você pode permanecer no programa resetando todas as informações");
                    Console.WriteLine("ou sair, já que o propósito do programa foi concluído.");
                    Console.WriteLine();
                    Console.WriteLine("[1] Reiniciar o sistema de Rifa");
                    Console.WriteLine("[2] Sair do Programa.");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        for (i = 0; i <= 49; i++)
                        {
                            status[i] = 'D';
                            nomes[i] = "";
                            telefones[i] = 0;
                        }
                    }
                    else
                    {
                        Sair = true;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Sistema de Rifa Modo Console - Made By Victor Henrique (UNISANTA-SI-2019)";
            int op;
            Rifa rifa = new Rifa();
            rifa.Sair = false;
            char cfg;
            string[] nomes = new string [50];
            long[] telefones = new long[50];
            char[] status = new char [50]; 

            for (int i = 0; i<=49; i++)
            {
                status[i] = 'D';
                nomes[i] = "";
                telefones[i] = 0;
            }

            do
            {
                Console.Clear();
                Console.WriteLine(">> Rifa Digital <<");
                Console.WriteLine(" Selecione uma das opções abaixo:");
                Console.WriteLine();
                Console.WriteLine("[1] Registrar venda de bilhete.");
                Console.WriteLine("[2] Consultar bilhete.");
                Console.WriteLine("[3] Alterar bilhete.");
                Console.WriteLine("[4] Excluir bilhete.");
                Console.WriteLine("[5] Gerar relatório.");
                Console.WriteLine("[6] Sortear um bilhete.");
                Console.WriteLine();
                Console.WriteLine("[7] Resetar todos os bilhetes.");
                Console.WriteLine();
                Console.WriteLine("[0] SAIR ");
                do
                {
                    Console.WriteLine();
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (op < 0 || op > 7 );

                switch (op)
                {
                    case 0:
                            Console.Clear();
                            Console.WriteLine("Tem certeza que deseja sair? (S/N)");
                            cfg = char.Parse(Console.ReadLine().ToUpper());
                            if (cfg == 'S')
                            {
                                rifa.Sair = true;
                            }
                            else
                            {
                                rifa.Sair = false;
                            }
                        break;
                    case 1:
                        rifa.RegistrarVenda(ref nomes, ref telefones, ref status);
                        break;
                    case 2:
                        rifa.ConsultarBilhete(ref nomes, ref status, ref telefones);
                        break;
                    case 3:
                        rifa.AlterarRifa(ref nomes, ref status, ref telefones);
                        break;
                    case 4:
                        rifa.ExcluirRifa(ref nomes, ref status, ref telefones);
                        break;
                    case 5:
                        rifa.GerarRelatorio(ref status);
                        break;
                    case 6:
                        rifa.Sortear(ref nomes, ref status, ref telefones);
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Você tem certeza que quer resetar TODOS os bilhetes da Rifa");
                        Console.WriteLine("Essa ação será irreversível.");
                        do
                        {
                            Console.WriteLine("Tem certeza deseja resetar? (S/N)");
                            cfg = char.Parse(Console.ReadLine().ToUpper());
                        } while (cfg != 'S' && cfg != 'N');
                        Console.Clear();

                        if (cfg == 'S')
                        {
                            for (int i = 0; i <= 49; i++)
                            {
                                status[i] = 'D';
                                nomes[i] = "";
                                telefones[i] = 0;
                            }
                            Console.WriteLine("Feito! Rifa resetada com suceso");
                            Console.WriteLine("Pressione uma tecla para continuar. . .");
                            Console.ReadKey();
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida");
                        Console.WriteLine("Pressione uma tecla para continuar. . .");
                        Console.ReadKey();
                        break;
                }
            } while (rifa.Sair == false);
        }
    }
}
