using Fundamentos.Models;
//OPERADORES CONDICIONAIS 

int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade do estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade da venda: {quantidadeCompra}");
Console.WriteLine($"é possivel realizar a venda: {possivelVenda}");

if( quantidadeCompra == 0) {
    Console.WriteLine("venda Inválida!");
}else if(possivelVenda){
    Console.WriteLine("Venda Realizada com Sucesso!");
}else{
    Console.WriteLine("Desculpe. Não temos essa quantidade em Estoque!");
}

// // TIPOS DE DADOS
// string nome = "ismael"; // a string sempre atribuida pelo valor entre aspas 
// Console.WriteLine($"Meu nome é {nome}");

// int idade = 26; // tipo numerico para inteiro 
// Console.WriteLine($"Tenho {idade}");

// decimal salario = 10000.00M; // o tipo numerico Decimal é recomendado para usar em valores monetarios
// Console.WriteLine($"Recebo {salario.ToString("c")}"); // ToString converte para uma saida em formato de string o "C" é para colocar no formato de valor monetario em reais

// DateTime dataatual = DateTime.Now; //DateTime é uma classe resevada para o tipo de dados de data .Now pega sempre á data atual pelo sistema da maquina que esta rodando o programa
// Console.WriteLine(dataatual);

// INSTANCIANDO UMA CLASSE 
// Pessoa p = new Pessoa();

// p.Nome = "Ismael";
// p.Idade = 26;

// p.Apresentar();