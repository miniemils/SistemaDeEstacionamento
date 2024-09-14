using src.Models;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.Write("Digite o preço inicial: ");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.Write("Agora digite o preço por hora: ");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
Estacionamento es = new Estacionamento(precoInicial, precoPorHora); 

Console.Clear();

bool exibirMenu = true;

while (exibirMenu) {
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch(Console.ReadLine()) {

        case "1": es.AdicionarVeiculo();
        break;

        case "2": es.RemoverVeiculo();
        break;

        case "3": es.ListarVeiculos();
        break;

        case "4": exibirMenu = false;
        break;

        default: Console.WriteLine("Opção inválida.");
        break;

    }

    Console.Write("Pressione uma tecla para continuar");
    Console.ReadLine();
    Console.Clear();
   
}