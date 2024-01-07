using Decola_tech.Models;

// Data e hora

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// Adiando apenas a data para 5 dias 

DateTime dataDiasSeguintes = DateTime.Now.AddDays(5);
Console.WriteLine(dataDiasSeguintes.ToString("dd/MM/yyyy"));

//Hora sem os Segundos

DateTime horaSemSegundos = DateTime.Now.AddDays(5);
Console.WriteLine(horaSemSegundos.ToString("HH:mm"));

//Apenas a data sem os segundos

DateTime data = DateTime.Now.AddDays(5);
Console.WriteLine(data.ToString("dd/MM/yyyy  HH:mm"));





// Testando sintaxe C#

string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.70;

decimal preco = 1.80M;

bool condicao = false;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);


// Testando class pessoa 

Pessoa p = new Pessoa();

p.Nome = "Ezequias";
p.Idade = 22;
p.Apresentar();


