namespace FilaDinamica
{
    internal class Fila
    {
        public Pessoa Head { get; set; }
        public Pessoa Tail { get; set; }
        

        public Fila()
        {
            Head = null;
            Tail = null;
        }

        public bool FilaVazia(Pessoa head)
        {
            if (head == null)
                return true;
            else
                return false;
        }

        public void InserirPessoa(Pessoa elemento, Pessoa head, Pessoa tail)
        {
            if (FilaVazia(head))
            {
                head = elemento;
                tail = head;
            }
            else
            {
                tail.Proximo = elemento;
                tail = elemento;
            }
            Head = head;
            Tail = tail;
        }

        public void RemoverPessoa(Pessoa head, Pessoa tail)
        {
            if (FilaVazia(head))
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                head = head.Proximo;
                if (head == null)
                {
                    tail = head;
                }
            }
            Head = head;
            Tail = tail;
        }

        public int TamanhoFila(Pessoa head)
        {
            var cont = 0;
            if (FilaVazia(head))
            {
                return cont;
            }
            else
            {
                Pessoa aux = head;
                do
                {
                    cont++;
                    aux = aux.Proximo;
                } while (aux != null);
            }

            return cont;
        }

        public void ExibirFila(Pessoa head)
        {
            if (FilaVazia(head))
            {
                Console.WriteLine("Fila Vazia");
            }
            else
            {
                Pessoa aux = head;
                while (aux != null)
                {
                    Console.WriteLine(aux.Nome);
                    aux = aux.Proximo;
                }
            }
        }
    }
}
