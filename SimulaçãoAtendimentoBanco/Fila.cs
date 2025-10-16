namespace SimulaçãoAtendimentoBanco;
public class Fila : Banco
{
    public Cliente Head { get; set; }
    public Cliente Tail { get; set; }

    public Fila()
    {
        Head = null;
        Tail = null;
    }

    public bool Vazia()
    {
        if (Head == null)
            return true;
        else
            return false;
    }
    public Fila Enfileirar(Cliente cliente)
    {
        if (Vazia())
        {
            Head = cliente;
            Tail = Head;
        }
        else
        {
            Tail.Proximo = cliente;
            Tail = cliente;
            Tail.Proximo = null;
        }

        return this;
    }

    public Cliente Desenfileirar()
    {
        if (Vazia())
        {
            Console.WriteLine("Fila Vazia!");
        }
        else
        {
            Head = Head.Proximo;
            if (Head == null)
            {
                Tail = Head;
            }

        }
        return Head;
    }


    public void MostrarFila()
    {
        if (Vazia())
        {
            Console.WriteLine("Fila vazia!");
        }
        else
        {
            var aux = Head;
            while(aux != null)
            {
                Console.WriteLine($"Nome: {aux.Nome}\nIdade: {aux.Idade}\n");
                aux = aux.Proximo;
            }
        }
    }
}
