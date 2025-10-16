namespace SimulaçãoAtendimentoBanco;

public class Banco
{
    public Fila FilaNormal { get; set; }
    public Fila FilaPrioritaria { get; set; }
    public int Contador { get; private set; }

    //public void AtenderCliente()
    //{
    //    Contador++;
    //    if (Contador < 3)
    //    {
    //        if (FilaNormal == null)
    //        {
    //            if (FilaPrioritaria == null)
    //            {
    //                Console.WriteLine("Duas filas vazias");
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Atendendo a fila prioritaria");
    //                Console.WriteLine($"Nome do cliente: {FilaPrioritaria.Head.Nome}\nIdade do Cliente: {FilaPrioritaria.Head.Idade}");
    //                FilaPrioritaria.Desenfileirar();
    //                Contador = 0;
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine($"Atendendo a fila normal");
    //            Console.WriteLine($"Nome do cliente: {FilaNormal.Head.Nome}");
    //            FilaNormal.Desenfileirar();
    //        }
    //    }
    //    else
    //    {
    //        if (FilaPrioritaria == null)
    //        {
    //            Console.WriteLine("Fila Prioritaria vazia");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"Atendendo a fila prioritaria");
    //            Console.WriteLine($"Nome do cliente: {FilaPrioritaria.Head.Nome}");
    //            FilaPrioritaria.Desenfileirar();
    //            Contador = 0;
    //        }
    //        Contador = 0;
    //    }
    //}

    public Cliente AtenderCliente()
    {
        if(FilaNormal == null && FilaPrioritaria == null)
        {
            return null;
        }
        else
        {
            if (FilaPrioritaria == null)
            {
                return FilaNormal.Desenfileirar();
            }
            else if (FilaNormal == null)
            {
                return FilaPrioritaria.Desenfileirar();
            }
            else
            {
                if(Contador % 3 == 0)
                {
                    Contador++;
                    return FilaPrioritaria.Desenfileirar();
                }
                else
                {
                    Contador++;
                    return FilaNormal.Desenfileirar();
                }
            }
        }
    }
}
