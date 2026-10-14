using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Fundamentos
{
    //sempre começar com public class "nome com letra maiuscula"
    public class Carro
    {
        //Atributos
        public string Marca;
        public string Modelo;
        public int Ano;
        //Metodos
        //Mostrar as informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}\n Modelo: {Modelo}\n Ano: {Ano}");
        }

    }
}
