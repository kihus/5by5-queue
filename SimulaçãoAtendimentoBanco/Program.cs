using SimulaçãoAtendimentoBanco;

var filaNormal = new Fila();
var filaPrioritaria = new Fila();
var banco = new Banco();

var opcao = 0;

do
{

    Console.Clear();
    Console.ResetColor();
    Console.WriteLine("[1] Adicionar cliente\r\n[2] Atender próximo cliente\r\n[3] Mostrar filas\r\n[0] Sair");
    Console.Write("-> ");

    opcao = int.Parse(Console.ReadLine() ?? "");

    switch (opcao)
    {
        case 1:
            Console.Write("Nome do cliente: ");
            var nome = Console.ReadLine();

            Console.Write("Idade do cliente: ");
            var idade = int.Parse(Console.ReadLine() ?? "");
            var cliente = new Cliente(nome, idade);
            if (cliente.Prioritario)
            {
                banco.FilaPrioritaria = filaPrioritaria.Enfileirar(cliente);
            }
            else
            {
                banco.FilaNormal = filaNormal.Enfileirar(cliente);
            }
            break;
        case 2:
            cliente = banco.AtenderCliente();

            if (cliente is null)
                Console.WriteLine("Nenhum cliente na fila");
            else
                Console.WriteLine(cliente);

            Console.WriteLine("\nPrecione enter para continuar... ");
            Console.ReadKey();
            break;
        case 3:
            if (banco.FilaNormal == null)
            {
                Console.WriteLine("Fila normal vazia");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fila normal!");
                banco.FilaNormal.MostrarFila();
                Console.ResetColor();
            }

            if (banco.FilaPrioritaria == null)
            {
                Console.WriteLine("Fila prioritaria vazia");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Fila prioritaria!");
                banco.FilaPrioritaria.MostrarFila();
                Console.ResetColor();
            }

            Console.WriteLine("\nPrecione enter para continuar... ");
            Console.ReadKey();
            break;

        case 0:
            Console.WriteLine("Obrigado por utilizar nosso programa");
            break;

        default:
            Console.WriteLine("Comando não reconhecido");
            break;
    }
} while (opcao != 0);