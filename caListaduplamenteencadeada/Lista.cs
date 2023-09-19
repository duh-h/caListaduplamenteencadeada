using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caListaduplamenteencadeada
{
    internal class Lista
    {
        public Noh Head { get; set; }


        public Lista()
        {
            this.Head = new Noh(0);
            this.Head.anterior = null;
            this.Head.proximo = null;
        }

        public void addInicio(int info)
        {
            Noh novoNoh = new Noh(info);

            if (this.Head.anterior == null)
            {
                this.Head.anterior = novoNoh;
                this.Head.proximo = novoNoh;
            }
            else
            {
                novoNoh.proximo = this.Head.anterior;
                this.Head.anterior.anterior = novoNoh;
                this.Head.anterior = novoNoh;
            }

        }
        public void addFim(int info)
        {
            Noh novoNoh = new Noh(info);

            if (this.Head.anterior == null)
            {
                this.Head.anterior = novoNoh;
                this.Head.proximo = novoNoh;
            }
            else
            {
                novoNoh.anterior = this.Head.proximo;
                this.Head.proximo.proximo = novoNoh;
                this.Head.proximo = novoNoh;
            }

        }

        public void Imprimirlista()
        {
            Noh atual = Head.anterior;

            while (atual != null)
            {
                Console.WriteLine(atual.info);
                atual = atual.proximo;
            }

            Console.WriteLine();
        }
        public int Remove(int info)
        {
            return RemoveRecursivo(Head.anterior, info);
        }

        private int RemoveRecursivo(Noh atual, int info)
        {

            if (atual == null)
            {
                Console.WriteLine("Nao encontrado");
                return default(int);
            }


            if (atual.info == info)
            {
                if (atual == Head.anterior)
                {
                    Head.anterior.proximo.anterior = null;
                    Head.anterior = Head.anterior.proximo;
                }
                else if (atual == Head.proximo)
                {
                    Head.proximo.anterior.proximo = null;
                    Head.proximo = Head.proximo.anterior;
                }
                else
                {
                    atual.anterior.proximo = atual.proximo;
                    atual.proximo.anterior = atual.anterior;
                }

                return info;

            }
            else
            {
                return RemoveRecursivo(atual.proximo, info);

            }


        }
        public int Maior()
        {
            if (Head.proximo == null)
            {
                Console.WriteLine("A lista está vazia.");
                return 0;
            }

            int maior = Head.anterior.info;
            Noh atual = Head.anterior;


            while (atual != null)
            {
                if (atual.info > maior)
                {
                    maior = atual.info;
                }


                atual = atual.proximo;
            }

            return maior;

        }

    }
}