using System.Runtime.Intrinsics.X86;

namespace SimulaçãoAtendimentoBanco;

public class Cliente
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public bool Prioritario { get; set; }

    public Cliente Proximo { get; set; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;

        if (idade > 65)
            Prioritario = true;
        else
            Prioritario = false;

        Proximo = null;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nIdade: {Idade}\nPrioritario: {(Prioritario ? "Sim" : "Não")}\n";
    }

}
