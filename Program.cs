﻿using System;

namespace DIO.Bank
{
        class Program
        {
            static List<Conta> listContas = new List<Conta>();
            static void Main(string[] args) 
            {
                
                string opcaoUsuario = ObterOpcaoUsuario();

                while (opcaoUsuario.ToUpper() != "X")
            {
                NewMethod(opcaoUsuario);
                opcaoUsuario = ObterOpcaoUsuario();
            }

            ConsoleWriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();

            }

        private static void NewMethod(string opcaoUsuario)
        
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarContas();
                    break;
                case "2":
                    InserirConta();
                    break;
                case "3":
                    Transferir();
                    break;
                case "4":
                    Sacar();
                    break;
                case "5":
                    Depositar();
                    break;
                case "C":
                    Console.Clear();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private static void  Transferir()
        {
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Tranferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Depositar()
        {
            Console.Write("Digite o numero da conta:");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            
            listContas[indiceConta].Depositar(valorDeposito);

        }

        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.Readline());

            listContas[indiceConta].Sacar(valorDeposito);

        }

        private static void ListarContas()
        {
            if (listContas.Count == 0)
        {
            Console.WriteLine("Nenhuma conta cadastrada.");
            return;
        }
        for(int i=0; i< listContas.Count; i++)
        {
            Conta conta = listContas[1];
            Console.Write("#{0} - ", i);
            Console.WriteLine(conta);
        }
     }

        private static void InserirConta()
        {

            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.Readline());

            Console.Write("Digite o Crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta) entradaTipoConta,
                                saldo: entradaSaldo,
                                credito: entradaCredito,
                                nome: entradaNome);

            listContas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("DIO Bank a seu dispor!");
                Console.WriteLine("Informe a opção desejada:");

                Console.WriteLine("1 - LIstar Contas");
                Console.WriteLine("2 - Inserir nova conta");
                Console.WriteLine("3 - Transferir");
                Console.WriteLine("4 - Sacar");
                Console.WriteLine("5 - Depositar");
                Console.WriteLine("C - Limpar Tela");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                string opcaoUsuario = ConsoleReadline().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;

                
            }
        }
}
