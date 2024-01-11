using Decola_tech.Models;


// Uso do "!" 

bool choveu = false;
bool EstaTarde = false;


if(!choveu && !EstaTarde){

    Console.WriteLine("Vou pedalar. ");

}else{

    Console.WriteLine("Não vou pedalar. ");

}



// Uso do "&&"


bool presencaMinima = true;
double mediaAprovacao = 7.5;

if(presencaMinima && mediaAprovacao >=6){

    Console.WriteLine("Media: "  + mediaAprovacao  + "\nAprovado com Sucesso!! ");

}else{

    Console.WriteLine("Reprovado. ");

}




// Uso do "OR"  


bool MaiorIdade = false;
bool AutorizacaoResponsavel = true;


if(MaiorIdade || AutorizacaoResponsavel == true){
 Console.WriteLine("Você pode viajar");
}else{
    Console.WriteLine("Não está autorizado. ");

}



// 

int quantidadeEmEstoque = 20;
int quantidadeCompra = 22;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque} ");
Console.WriteLine($"Quantidade Comprar: {quantidadeCompra} ");
Console.WriteLine($"è possivel realizar a venda? {possivelVenda} ");

if(quantidadeCompra == 0)
{
    Console.WriteLine("Nenhuma Venda Realizada. ");

}else if(possivelVenda){

    Console.WriteLine( quantidadeCompra + "- Venda Realizada com Sucesso! " );

}else{

    Console.WriteLine("Sem Estoque...");

}













//Atualizar um número para String 

int inteiro = 5;
string a =inteiro.ToString();

Console.WriteLine(a);


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


