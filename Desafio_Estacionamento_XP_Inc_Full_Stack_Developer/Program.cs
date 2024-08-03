// Coloca o encoding para UTF8 para exibir acentuação
using Desafio_Estacionamento_XP_Inc_Full_Stack_Developer.Model;
using System;

public class Program
{
    enum Opcoes
    {
            AdicionarVeiculo = 1,
            RemoverVeiculo = 2,
            ListarVeiculo = 3,
            Encerrar = 4
        }
    public static void Main() {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        decimal precoInicial = 0;
        decimal precoPorHora = 0;

        Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \nDigite o preço inicial:");
        precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Agora digite o preço por hora:");
        precoPorHora = Convert.ToDecimal(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial: precoInicial, precoPorHora: precoPorHora);

       Opcoes opcao;
        bool exibirMenu = true;

        // Menu
        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            opcao = (Opcoes)Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case Opcoes.AdicionarVeiculo:
                    estacionamento.AdicionarVeiculo();
                    break;

                case Opcoes.RemoverVeiculo:
                    estacionamento.RemoverVeiculo();
                    break;

                case Opcoes.ListarVeiculo:
                    estacionamento.ListarVeiculos();
                    break;

                case Opcoes.Encerrar:
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("O programa se encerrou");
    }
}
