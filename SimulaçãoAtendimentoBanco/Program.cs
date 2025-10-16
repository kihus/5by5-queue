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

            if (idade >= 65)
            {
                var cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Idade = idade;
                cliente.Prioritario = true;
                banco.FilaPrioritaria = filaPrioritaria.Enfileirar(cliente);
            }
            else
            {
                var cliente = new Cliente();
                cliente.Nome = nome;
                cliente.Idade = idade;

                banco.FilaNormal = filaNormal.Enfileirar(cliente);
            }
            break;
        case 2:
            banco.AtenderCliente();
            Console.WriteLine("\nPrecione enter para sair... ");
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

            Console.WriteLine("\nPrecione enter para sair... ");
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