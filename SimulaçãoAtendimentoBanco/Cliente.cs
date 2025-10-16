namespace SimulaçãoAtendimentoBanco;

public class Cliente
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public bool Prioritario { get; set; }

    public Cliente Proximo { get; set; }

    public Cliente()
    {
        Proximo = null;
    }

}
