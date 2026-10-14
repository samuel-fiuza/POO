using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    public class Pedidio
    {
        //atributos - caracteristicas
        public string Nome;
        public string Item;
        public int Quantidade;
        public double Preco;

        //metodo - ações
        public void InformacoesDoPedido()
        {
            Console.WriteLine($"Nome: {Nome}\nItem: {Item}\nQuantidade: {Quantidade}\nPreco: {Preco}");
        }
    }
}
