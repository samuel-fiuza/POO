/*como eu instancio um objeto?
1. Criar classe
1 classe = 1 arquivo
*/

//objeto
//Variavel
//TIPO NOME
using POO_Fundamentos;

//Instanciar
Carro carroDoVini = new Carro();

carroDoVini.Modelo = "HB20S";
carroDoVini.Marca = "Hyundai";
carroDoVini.Ano = 2024;

carroDoVini.ExibirInformacoes();

//Instanciel um novo objeto

Carro carroLegal = new Carro();

carroLegal.Modelo = "Legal";
carroLegal.Marca = "Marca Legal";
carroLegal.Ano = 1976;

carroLegal.ExibirInformacoes();

Console.WriteLine(carroLegal);


//Classe Pedido
//NomeDoCliente, item, quantidad, preco
/*
Pedidio NovoPedido = new Pedidio();
Console.WriteLine("Digite o nome do cliente");
NovoPedido.Nome = Console.ReadLine();
Console.WriteLine("Dígite o item do pedido");
NovoPedido.Item = Console.ReadLine();
Console.WriteLine("Quantidade do pedido");
NovoPedido.Quantidade = int.Parse(Console.ReadLine());
Console.WriteLine("O preço do pedido");
NovoPedido.Preco = double.Parse(Console.ReadLine());

NovoPedido.InformacoesDoPedido();

Console.WriteLine(NovoPedido);
*/
//Exercicios fundamentais
//1. Pessoas
/*
Pessoa NovaPessoas = new Pessoa();
Console.WriteLine("Dígite seu nome");
NovaPessoas.Nome = Console.ReadLine();
Console.WriteLine("Dígite sua idade");
NovaPessoas.Idade = int.Parse(Console.ReadLine());

NovaPessoas.Apresentacoes();

Pessoa NovaPessoas2 = new Pessoa();
Console.WriteLine("Dígite seu nome");
NovaPessoas2.Nome = Console.ReadLine();
Console.WriteLine("Dígite sua idade");
NovaPessoas2.Idade = int.Parse(Console.ReadLine());

NovaPessoas2.Apresentacoes();

Console.WriteLine(NovaPessoas);
Console.WriteLine(NovaPessoas2);

//2. Retangulo
Retangulo contaArea = new Retangulo();
contaArea.Altura = 20;
contaArea.Largura = 4;

Retangulo contaPerimetro = new Retangulo();
contaPerimetro.Altura = 10;
contaPerimetro.Largura = 20;

//Poderia-se  criar uma váriavel para demonstrar os resultados com outra alternativa
Console.WriteLine(contaArea.CalcularArea());
Console.WriteLine(contaPerimetro.CalcularPerimetro());

//3. Lampada
Lampada ExibirEstado = new Lampada();
Console.WriteLine(ExibirEstado.Alternar());
Lampada Desligar = new Lampada();
Desligar.Desligar();
Console.WriteLine(ExibirEstado.Alternar());
Lampada Ligar = new Lampada();
Ligar.Ligar();
Console.WriteLine(ExibirEstado.Alternar());
*/


//Exercicios fundamentais Classes e Metodos
//1. Saudações
Pessoa2 Samuel = new Pessoa2();

Samuel.Nome = "Samuel";

Samuel.Cumprimentar();
Samuel.CumprimentarAlguem("Bruno");

string frase = Samuel.ObterApresentação();
Console.WriteLine(frase);

//2. Calculadora
Calculadora calc = new Calculadora();
int soma = calc.Somar(10, 5);
calc.MostrarResultaos(soma);

int sub = calc.Subtrair(30, 20);
calc.MostrarResultaos(sub);

//3. Conversor de Temperatura
ConversorTemp conv = new ConversorTemp ();

double f = conv.CalcularCelciusParaFahrenheint(25);
Console.WriteLine($"25C = {f}F");

if (conv.EstaQuente(35))
{
    Console.WriteLine("35C: está quente!");
} 

if (!conv.EstaQuente(18))
{
    Console.WriteLine("18C: não está quente");
}