using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Abstracao
{
    internal interface INotificador
    {
        //Apenas metodos
        void Enviar(string mensagem);
    }
    public class Email : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Email disparado: {mensagem}");
        }
    }
    // Mensagem SMS
    public class SMS : INotificador
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine($"Mensagem SMS enviada: {mensagem}");
        }
    }
}
