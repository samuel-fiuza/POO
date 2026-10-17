using System;
using System.Collections.Generic;
using System.Text;

namespace PIlares_POO.Abstracao
{
    public interface INotificador
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

    public class Loja
    {
        //Da problema se Inotificador não estiver publico pois se é recomendado fazer tudo em uma pasta separada
        public void Finalizar(INotificador notificador)
        {
            notificador.Enviar("compra finaizada");
        }
    }
}
