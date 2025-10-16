using FilaDinamica;

var fila = new Fila();

var usando = false;
do
{
    Console.Clear();
    Console.WriteLine("1 - Inserir Pessoa | 2 - Remover Pessoa | 3 - Tamanho da Fila | 4 - Exibir Fila | 5 - Sair");
    Console.Write("-> ");
    var opcao = int.Parse(Console.ReadLine() ?? "");

    switch (opcao)
    {
        case 1:
            Console.Write("Digite o nome da pessoa que vai ser adicionado: ");
            Pessoa nome = new Pessoa();
            nome.Nome = Console.ReadLine() ?? "";
            fila.InserirPessoa(nome, fila.Head, fila.Tail);
            break;
        case 2:
            fila.RemoverPessoa(fila.Head, fila.Tail);
            Console.WriteLine("Pessoa removida!");
            break;
        case 3:

            var cont = fila.TamanhoFila(fila.Head);
            Console.WriteLine($"Tamanho da fila: {cont}");
            
            break;
        case 4:
            fila.ExibirFila(fila.Head);
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Obrigado por usar nosso programa");
            usando = true;
            break;
        default:
            Console.WriteLine("\nDigite corretamente");
            break;
    }
    Console.ReadKey();

} while (!usando);

