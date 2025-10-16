namespace SimulaçãoAtendimentoBanco;

public class Banco
{
    public Fila FilaNormal { get; set; }
    public Fila FilaPrioritaria { get; set; }
    public int Contador { get; private set; }

    public void AtenderCliente()
    {
        Contador++;
        if (Contador < 3)
        {
            if (FilaNormal.Vazia())
            {
                if (FilaPrioritaria.Vazia())
                {
                    Console.WriteLine("Duas filas vazias");
                }
                else
                {
                    Console.WriteLine($"Atendendo a fila prioritaria");
                    Console.WriteLine($"Nome do cliente: {FilaPrioritaria.Head.Nome}");
                    FilaPrioritaria.Desenfileirar();
                    Contador = 0;
                }
            }
            else
            {
                Console.WriteLine($"Atendendo a fila normal");
                Console.WriteLine($"Nome do cliente: {FilaNormal.Head.Nome}");
                FilaNormal.Desenfileirar();
            }
        }
        else
        {
            if (FilaPrioritaria.Vazia())
            {
                Console.WriteLine("Fila Prioritaria vazia");
            }
            else
            {
                Console.WriteLine($"Atendendo a fila prioritaria");
                Console.WriteLine($"Nome do cliente: {FilaPrioritaria.Head.Nome}");
                FilaPrioritaria.Desenfileirar();
                Contador = 0;
            }
            Contador = 0;
        }
    }
}
