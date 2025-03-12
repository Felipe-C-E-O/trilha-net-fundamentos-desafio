using DesafioFundamentosFelipe.Models;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja Bem vindo ao sistema de estacionamento!\n" + 
                    "Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora :");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estaciona = new Estacionamento(precoInicial , precoPorHora);

bool exibirMenu = true;

// Realizando o loop do menu

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1- Cadastrar veículo");
    Console.WriteLine("2- Remover veículo");
    Console.WriteLine("3- Listar veículo");
    Console.WriteLine("4- Encerrar");

    //estrutura de desição switch

    switch (Console.ReadLine())
    {
        case "1":
            estaciona.AdicionarVeiculo();
        break;

        case "2":
            estaciona.RemoverVeiculo();
        break;

        case "3":
            estaciona.ListarVeiculos();
        break;

        case "4":
            exibirMenu = false ;
        break;

        default:
        Console.WriteLine("Opção inválida");
        break;
    }
    Console.WriteLine("Pressione uma Tecla para Continuar");
    Console.ReadLine();






}
Console.WriteLine("O programa se encerrou");
