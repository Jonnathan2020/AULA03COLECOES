using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Aula03Colecoes.Models;
using Aula03Colecoes.Models.Enuns;

namespace Aula03Colecoes
{
    public class Program
    {
        //lista global pois não esta dentro de nenhuma classe
        public static List<Funcionario> nomeLista = new List<Funcionario>();

        static void Main(string[]args)
        {
            ExibirLista();
            ExemplosListasColecoes();
        }

        public static void CriarLista()
        {

            Funcionario f1 = new Funcionario();
            f1.Id = 1;
            f1.Nome = "Janiscleudo";
            f1.Cpf = "12345678910";
            f1.DataAdmissao = DateTime.Parse("16/05/1900");
            f1.Salario  = 100.000M;
            f1.TipoFuncionario = TipoFuncionarioEnum.CLT;
            nomeLista.Add(f1);

            Funcionario f2 = new Funcionario();
            f2.Id = 2;
            f2.Nome = "Cristiano Ronaldo";
            f2.Cpf = "01987654321";
            f2.DataAdmissao = DateTime.Parse("30/06/2002");
            f2.Salario = 150.000M;
            f2.TipoFuncionario = TipoFuncionarioEnum.CLT;
            nomeLista.Add(f2);

            Funcionario f3 = new Funcionario();
            f3.Id = 3;
            f3.Nome = "Messi";
            f3.Cpf = "135792468";
            f3.DataAdmissao = DateTime.Parse("01/11/2003");
            f3.Salario = 70.000M;
            f3.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            nomeLista.Add(f3);

            Funcionario f4 = new Funcionario();
            f4.Id = 4;
            f4.Nome = "Mbappe";
            f4.Cpf = "246813579";
            f4.DataAdmissao = DateTime.Parse("15/09/2005");
            f4.Salario = 80.000M;
            f4.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            nomeLista.Add(f4);

            Funcionario f5 = new Funcionario();
            f5.Id = 5;
            f5.Nome = "Lewa";
            f5.Cpf = "246813579";
            f5.DataAdmissao = DateTime.Parse("20/10/1998");
            f5.Salario = 90.000M;
            f5.TipoFuncionario = TipoFuncionarioEnum.Aprendiz;
            nomeLista.Add(f5);

            Funcionario f6 = new Funcionario();
            f6.Id = 6;
            f6.Nome = "Rodrigo Garro";
            f6.Cpf = "246813579";
            f6.DataAdmissao = DateTime.Parse("13/12/1997");
            f6.Salario = 300.000M;
            f6.TipoFuncionario = TipoFuncionarioEnum.CLT;
            nomeLista.Add(f6);
        }

        public static void ExibirLista()
        {
            List<Funcionario> nomeLista = new List<Funcionario>();

            string dados = " ";
            for(int i= 0; i< nomeLista.Count; i++)
            {
                dados += "===================================\n";
                dados += string.Format("Id: {0} \n", nomeLista[i].Id);
                dados += string.Format("Nome: {0} \n", nomeLista[i].Nome);
                dados += string.Format("CPF: {0} \n", nomeLista[i].Cpf);
                dados += string.Format("Admissão: {0:dd/MM/yyyy} \n", nomeLista[i].DataAdmissao);
                dados += string.Format("Salario: {0} \n", nomeLista[i].Salario);
                dados += string.Format("Tipo: {0} \n", nomeLista[i].TipoFuncionario);
                
            }
        }

         public static void ObterPorId()
        {            
            nomeLista = nomeLista.FindAll(x => x.Id == 1);
            ExibirLista();
        }
        

        public static void ObterPorId(int id)
        {            
            Funcionario fBusca = nomeLista.Find(x => x.Id == id);

            Console.WriteLine($"Personagem encontrado: {fBusca.Nome}");
        }

        public static void ExemplosListasColecoes()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("****** Exemplos - Aula 03 Listas e Coleções ******");
            Console.WriteLine("==================================================");
            CriarLista();
            int opcaoEscolhida = 0;
            do
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("---Digite o número referente a opção desejada: ---");
                Console.WriteLine("1 - Obter Por Id");
                Console.WriteLine("2 - Adicionar Funcionário");
                Console.WriteLine("3 - Obter Por Id digitado");
                Console.WriteLine("4 - Obter por Salario");
                Console.WriteLine("5 - Obter por Nome");
                Console.WriteLine("6 - Obter por Funcionarios recentes");
                Console.WriteLine("7 - Obter Estatisticas");
                Console.WriteLine("==================================================");
                Console.WriteLine("-----Ou tecle qualquer outro número para sair-----");
                Console.WriteLine("==================================================");
                opcaoEscolhida = int.Parse(Console.ReadLine());
                string mensagem = string.Empty;
                switch (opcaoEscolhida)
                {
                    case 1:
                        ObterPorId();
                    break;
                    case 2:
                    break;
                    case 3:
                        Console.WriteLine("Digite o Id do funcionario que voce deseja buscar");
                        int id = int.Parse(Console.ReadLine());
                        ObterPorId(id);
                    break;
                    case 4:
                    break;
                    case 5:
                    break;
                    case 6:
                    break;
                    case 7:
                    break;
                    default:
                    Console.WriteLine("Saindo do sistema....");
                    break;
                }
            }while (opcaoEscolhida >= 1 && opcaoEscolhida <= 10);
                Console.WriteLine("==================================================");
                Console.WriteLine("* Obrigado por utilizar o sistema e volte sempre *");
                Console.WriteLine("==================================================");
            
        }

        public static void ObterPorSalario(decimal valor)
        {
            nomeLista = nomeLista.FindAll(x => x.Salario >= valor);
            ExibirLista();
        }

        public static void ObterporNome(string nome)
        {
            Funcionario fBusca = nomeLista.FindAll(x => x.Nome == nome);

            Console.WriteLine($"Funcionário encontrado: {fBusca.Nome}");
        }

        public static void ObterFuncionariosRecentes(int recentes)
        {                 
            
        
        }

        public static void ObterEstatisticas()
        {
            decimal soma = nomeLista.Sum(x=> x.Salario);

            Console.WriteLine($"A quantidade de funcionarios é: {nomeLista.Count}");
            Console.WriteLine($"A soma do salário de todos funcionarios é: {soma}");
        }

        public static void ValidarSalarioAdmissao()
        {

        }



    }
}