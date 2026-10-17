
using Pilares_POO;
using PIlares_POO;
using PIlares_POO.Hrenca;
using PIlares_POO.Polimorfismo.Exercicio1;
using PIlares_POO.Polimorfismo.Exercicio2;
using PIlares_POO.Polimorfismo.Exercicio3;
using System.Globalization;
/*
Carro carro1 = new Carro("Hyundai", "HB20" );
Console.WriteLine(carro1.Marca);
Console.WriteLine(carro1.Modelo);

//Metodo-Construtor - Obriga o objeto a ser criado de uma forma
//Pilares POO
//Evitar estados invalidos
//Encapsulamento - protege classes. atributos e métodos
//public, inter e private são encapsulamentos
//public - Acessado de qualquer lugar
//private Acessar de dentro da classe             
//inter - Acessar do projeto
//GET - função de ler o valor
//SET - função de mudar o valor
ContaBancaria conta1 = new ContaBancaria();
//conta1.Saldo = -500; (exemplo de algo que daria errado)

//Exercicios Fundamentais de Metodo Contrstrutor
//1. Livro

Livro livro1 = new Livro("Senhor dos Anéis", "Tolken", 400);
Livro livro2 = new Livro("Diario de um Banana", "Greg Raffley", 211);

livro1.Exibir();
livro2.Exibir();

//2. Viagem
Viagem viagemFoda = new Viagem("Fortaleza", 10, 69.99);

viagemFoda.Exibir();

//3. contato (dois metodos contrutor)
Contato c1 = new Contato("Samuel", "(11) 98705-1553", "samuel.ffiuza@gmail.com");
Contato c2 = new Contato("Bruno", "(21) 98888-1111");

c1.Exibir();
c2.Exibir();

//Exercicios de Encapsulamento
//1. Contador de Visitas

ContVisit contador = new ContVisit();

contador.RegistrarVisitas();
contador.RegistrarVisitas();
contador.RegistrarVisitas();

Console.WriteLine($"Total de visitas: {contador.ValorTotal()}");

//2. Boletim
Boletim boletim = new Boletim();
boletim.Aluno = "Samuel";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");

//Herança ("explicação" na pasta "herança" atraves das classe) 
Aluno aluno  = new Aluno();

aluno.Idade = 20;
aluno.Nome = "Bruno";

aluno.Apresentar();


//Exercicios de herança
//1. Animal e Cachorro
Cachorro cachorro = new Cachorro();
cachorro.Nome = "Rex";

cachorro.Comer();
cachorro.Latir();

//2. Funcionario e Gerente
Funcionario ana = new Funcionario("Ana", 3000);
Gerente carlos = new Gerente("Carlos", 5000, 1500);

Console.WriteLine($"{ana.Nome}: R${ana.Salario}");
Console.WriteLine($"{carlos.Nome}: R${carlos.Salario} + bonus = R${carlos.SalarioComBonus()}");

//3. Veiculo, Carro e Moto
Carro1 carro = new Carro1 ("Fiat", "Uno", 4);
Moto moto = new Moto("Honda", "CG 160", 160);

carro.Exibir();
carro.ExibirPortas();

moto.Exibir();
moto.ExibirCilindradas(); 


//Polimorfismo (muitas formas: uma mesma funçaõ pode ter muitas formas | uma funçaõ pode fazer coisas diferentes
//polimorfismo pode atuar de duas maneiras diferentes que são:
//-- sobrecarga: Mesmo metodo(nome) com parametros diferentes
//-- sobrescrita: pode ter dois metodos virtual e overrider (sobrescrita precisa de herança)
//virtual - da permissão para o metodo ser sobrescrito
//override - Sobrescreve

//Exercicios de polimorfismo
//1. Saudações
Saudacao s = new Saudacao();

s.Comprimentar();
s.Comprimentar("Samuel");
s.Comprimentar("Samuel", 16);

//2. Calculadora de area
CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine(calc.CalcularArea(4));
Console.WriteLine(calc.CalcularArea(5, 10));

//3. Instrumento e violão
Instrumento instrumento = new Instrumento();
Violao violao = new Violao();

instrumento.Tocar();
violao.Tocar();

*/ 