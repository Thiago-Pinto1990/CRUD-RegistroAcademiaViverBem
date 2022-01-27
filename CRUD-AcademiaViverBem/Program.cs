using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_AcademiaViverBem
{
    class Program
    {
        static AlunoRepositorio interacaoAluno = new AlunoRepositorio();
        static ProfessorRepositorio interacaoProfessor = new ProfessorRepositorio();
        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();//TRABALHANDO ESCOLHA DO USUÁRIO
            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "0":
                        ListarAluno();
                        break;
                    case "1":
                        ListarProfessor();
                        break;
                    case "2":
                        InserirAluno();
                        break;
                    case "3":
                        InserirProfessor();
                        break;
                    case "4":
                        AtualizarAluno();
                        break;
                    case "5":
                        AtualizarProfessor();
                        break;
                    case "6":
                        ExcluirAluno();
                        break;
                    case "7":
                        ExcluirProfessor();
                        break;
                    case "8":
                        VisualizarAluno();
                        break;
                    case "9":
                        VisualizarProfessor();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida !");
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void VisualizarAluno()//MÉTODO PARA VISUALIZAR ALUNO REGISTRADO
        {
            var lista = interacaoAluno.Lista();
            
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Aluno Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Índice do Aluno: ");
                int indiceAluno = int.Parse(Console.ReadLine());
                var aluno = interacaoAluno.RetornaPorIndice(indiceAluno);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Visualizar Aluno");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine(aluno);
            }
        }

        private static void VisualizarProfessor()//MÉTODO PARA VISUALIZAR PROFESSOR REGISTRADO
        {
            var lista = interacaoProfessor.Lista();
            
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Professor Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Índice do Professor: ");
                int indiceProfessor = int.Parse(Console.ReadLine());
                var professor = interacaoProfessor.RetornaPorIndice(indiceProfessor);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Visualziar Professor");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine(professor);
            }
        }

        private static void ExcluirAluno()//MÉTODO PARA MARCAR REGISTRO DE ALUNO COMO EXCLUÍDO
        {
            var lista = interacaoAluno.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=");
            Console.WriteLine("Excluir Aluno");
            Console.WriteLine("=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Aluno Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Índice do Aluno: ");
                int indiceAluno = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir o Aluno {indiceAluno} [S] ou [N] ?: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    interacaoAluno.Exclui(indiceAluno);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
        }

        private static void ExcluirProfessor()//MÉTODO PARA MARCAR REGISTRO DE ALUNO COMO EXCLUÍDO
        {
            var lista = interacaoProfessor.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Excluir Professor");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Professor Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Índice do Professor: ");
                int indiceProfessor = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir o Professor {indiceProfessor} [S] ou [N] ?: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    interacaoProfessor.Exclui(indiceProfessor);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
        }

        private static void AtualizarAluno()//MÉTODO PARA ATUALIZAR REGISTRO DE ALUNO
        {
            var lista = interacaoAluno.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-");
            Console.WriteLine("Atualizar Aluno");
            Console.WriteLine("=-=-=-=-=-=-=-=-");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Aluno Cadastrado\n");
            }
            else
            {
                Console.Write("Atualize o Índice do Aluno: ");
                int indiceAluno = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Novo Aluno");
                foreach (int i in Enum.GetValues(typeof(Modalidade)))
                {
                    Console.WriteLine($"{i}-{Enum.GetName(typeof(Modalidade), i)}");
                }
                Console.Write("Digite a Modalidade: ");
                int entradaModalidade = int.Parse(Console.ReadLine());
                Console.Write("Digite o Nome: ");
                string entradaNome = Console.ReadLine();
                Console.Write("Digite a Matrícula: ");
                string entradaMatricula = Console.ReadLine();
                Console.Write("Digite a Data de Nascimento: ");
                string entradaDtnascimento = Console.ReadLine();
                Console.Write("Digite a Data de Entrada na Academia: ");
                string entradaDtEntrada = Console.ReadLine();
                Console.Write("Digite a Mensalidade: ");
                double entradaMensalidade = double.Parse(Console.ReadLine());

                Aluno atualizaAluno = new Aluno(nome: entradaNome,
                                                matricula: entradaMatricula,
                                                modalidade: (Modalidade)entradaModalidade,
                                                dataNascimento: entradaDtnascimento,
                                                dataEntrada: entradaDtEntrada,
                                                mensalidade: entradaMensalidade);

                interacaoAluno.Atualiza(indiceAluno, atualizaAluno);

            }
        }

        private static void AtualizarProfessor()//MÉTODO PARA ATUALIZAR REGISTRO DE ALUNO
        {
            var lista = interacaoProfessor.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Atualizar Professor");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Professor Cadastrado\n");
            }
            else
            {
                Console.Write("Atualize o Índice do Professor: ");
                int indiceProfessor = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Novo Professor");
                foreach (int i in Enum.GetValues(typeof(Modalidade)))
                {
                    Console.WriteLine($"{i}-{Enum.GetName(typeof(Modalidade), i)}");
                }
                Console.Write("Digite a Modalidade: ");
                int entradaModalidade = int.Parse(Console.ReadLine());
                Console.Write("Digite o Nome: ");
                string entradaNome = Console.ReadLine();
                Console.Write("Digite a Matrícula: ");
                string entradaMatricula = Console.ReadLine();
                Console.Write("Digite a Data de Nascimento: ");
                string entradaDtnascimento = Console.ReadLine();
                Console.Write("Digite a Data de Entrada na Academia: ");
                string entradaDtEntrada = Console.ReadLine();
                Console.Write("Digite o Salário: ");
                double entradaSalario = double.Parse(Console.ReadLine());

                Professor atualizaProfessor = new Professor(nome: entradaNome,
                                                matricula: entradaMatricula,
                                                modalidade: (Modalidade)entradaModalidade,
                                                dataNascimento: entradaDtnascimento,
                                                dataEntrada: entradaDtEntrada,
                                                salario: entradaSalario);

                interacaoProfessor.Atualiza(indiceProfessor, atualizaProfessor);

            }
        }

        private static void InserirAluno()//MÉTODO PARA INSERIR NOVO REGISTRO DE ALUNO
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Inserir Novo Aluno");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-");
            foreach (int i in Enum.GetValues(typeof(Modalidade)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Modalidade), i)}");
            }
            Console.Write("Digite a Modalidade: ");
            int entradaModalidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome: ");
            string entradaNome = Console.ReadLine();
            Console.Write("Digite a Matrícula: ");
            string entradaMatricula = Console.ReadLine();
            Console.Write("Digite a Data de Nascimento: ");
            string entradaDtnascimento = Console.ReadLine();
            Console.Write("Digite a Data de Entrada na Academia: ");
            string entradaDtEntrada = Console.ReadLine();
            Console.Write("Digite a Mensalidade: ");
            double entradaMensalidade = double.Parse(Console.ReadLine());

            Aluno novoAluno = new Aluno(nome: entradaNome,
                                            matricula: entradaMatricula,
                                            modalidade: (Modalidade)entradaModalidade,
                                            dataNascimento: entradaDtnascimento,
                                            dataEntrada: entradaDtEntrada,
                                            mensalidade: entradaMensalidade);

            interacaoAluno.Insere(novoAluno);
        }

        private static void InserirProfessor()//MÉTODO PARA INSERIR NOVO REGISTRO DE PROFESSOR
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Inserir Novo Professor");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=");
            foreach (int i in Enum.GetValues(typeof(Modalidade)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Modalidade), i)}");
            }
            Console.Write("Digite a Modalidade: ");
            int entradaModalidade = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome: ");
            string entradaNome = Console.ReadLine();
            Console.Write("Digite a Matrícula: ");
            string entradaMatricula = Console.ReadLine();
            Console.Write("Digite a Data de Nascimento: ");
            string entradaDtnascimento = Console.ReadLine();
            Console.Write("Digite a Data de Entrada na Academia: ");
            string entradaDtEntrada = Console.ReadLine();
            Console.Write("Digite o Salário: ");
            double entradaSalario = double.Parse(Console.ReadLine());

            Professor novoProfessor = new Professor(nome: entradaNome,
                                            matricula: entradaMatricula,
                                            modalidade: (Modalidade)entradaModalidade,
                                            dataNascimento: entradaDtnascimento,
                                            dataEntrada: entradaDtEntrada,
                                            salario: entradaSalario);

            interacaoProfessor.Insere(novoProfessor);
        }

        private static void ListarAluno()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=");
            Console.WriteLine("Listar Alunos");
            Console.WriteLine("=-=-=-=-=-=-=-=");
            var lista = interacaoAluno.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Aluno Cadastrado\n");
            }
            else
            {
                foreach (var aluno in lista)
                {
                    var excluido = aluno.RetornaExcluido();
                    Console.WriteLine($"#ID {interacaoAluno.ProximoIndice() - 1}: - {aluno.RetornaNome()}  {(excluido ? "Excluído" : "")}");
                }   
            }

        }

        private static void ListarProfessor()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Listar Professores");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
            var lista = interacaoProfessor.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Professor Cadastrado\n");
            }
            else
            {
                foreach (var professor in lista)
                {
                    var excluido = professor.RetornaExcluido();
                    Console.WriteLine($"#ID {interacaoProfessor.ProximoIndice() - 1}:  {professor.RetornaNome()}  {professor.Matricula}  {(excluido ? "Excluído" : "")}");
                }   
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\n");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("ACADEMIA VIVER BEM");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("0 - Listar Alunos");
            Console.WriteLine("1 - Listar Professores");
            Console.WriteLine("2 - Inserir Novo Aluno");
            Console.WriteLine("3 - Inserir Novo Professor");
            Console.WriteLine("4 - Atualizar Aluno");
            Console.WriteLine("5 - Atualizar Professor");
            Console.WriteLine("6 - Excluir Aluno");
            Console.WriteLine("7 - Excluir Professor");
            Console.WriteLine("8 - Visualizar Aluno");
            Console.WriteLine("9 - Visualizar Professor");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("\n");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            return opcaoUsuario;
        }
    }
}
