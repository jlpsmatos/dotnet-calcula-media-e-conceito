using System;

namespace CalcularMediaConceitoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                 switch (opcaoUsuario)
                 {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("##### Calcular Média/Conceito Aluno #####");
                        Console.WriteLine();
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Informe a nota do aluno:");
                        aluno.Nota = decimal.Parse(Console.ReadLine());
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        Console.Clear();
                        Console.WriteLine("##### Calcular Média/Conceito Aluno #####");
                        Console.WriteLine();
                        Console.WriteLine("Novo aluno inserido com sucesso!");
                        Console.WriteLine();
                        Console.WriteLine("Pressione <Enter> para voltar... ");
                        Console.ReadLine();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("##### Calcular Média/Conceito Aluno #####");
                        Console.WriteLine();
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"ALUNO: {a.Nome} / NOTA: {a.Nota}");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Pressione <Enter> para voltar... ");
                        Console.ReadLine();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("##### Calcular Média/Conceito Aluno #####");
                        Console.WriteLine();
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome)){
                               notaTotal = notaTotal + alunos[i].Nota;
                               nrAlunos++; 
                            }
                        }
                        var mediaGeral = notaTotal/nrAlunos;
                        Conceito conceitoGeral;

                        if(mediaGeral<2)
                        {
                            conceitoGeral = Conceito.E;
                        } else if(mediaGeral<4)
                        {
                            conceitoGeral = Conceito.D;
                        } else if(mediaGeral<6)
                        {
                            conceitoGeral = Conceito.C;
                        } else if(mediaGeral<8)
                        {
                            conceitoGeral = Conceito.B;
                        } else
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"MÉDIA GERAL: {mediaGeral} / CONCEITO: {conceitoGeral}");
                        Console.WriteLine();
                        Console.WriteLine("Pressione <Enter> para voltar... ");
                        Console.ReadLine();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;
                     default:
                        Console.Clear();
                        Console.WriteLine("##### Calcular Média/Conceito Aluno #####");
                        Console.WriteLine();
                        Console.WriteLine("Opção indisponível!");
                        Console.WriteLine();
                        Console.WriteLine("Pressione <Enter> para voltar... ");
                        Console.ReadLine();
                        opcaoUsuario = ObterOpcaoUsuario();
                        break;
                 }
            }

        }
        private static string ObterOpcaoUsuario()
        {
            Console.Clear();
            Console.WriteLine("##### Calcular Média/Conceito Aluno #####");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
