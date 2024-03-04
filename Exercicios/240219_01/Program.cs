// Trabalhando com variáveis C#
using System;

//Strings
//Declarando variável sem inicialização
string message1 = null;
// Inicializar a variável com nulo
string message2 = null;
// Inicializar a string vazia
string message3 = System.String.Empty; // "";
// Declarar uma string com valor implícito
var message4 = "Uma mensagem aleatória";

Console.WriteLine( message4 );

// Concatenando Strings
string concat = (message1 == null ? "" : message1) + 
                " " + message2 + " " + 
                message3 + " " + message4;
Console.WriteLine( "\n" + concat );

Console.WriteLine( 
    "A Temperatura hoje {0:D} é {1}°C"
    , DateTime.Now
    , 23
);

string nome = string.Empty;
Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
string resultado = $"Oi, {nome}! Pare de jaguarice!";
Console.WriteLine(resultado);

// Comentário de marcação 240304

// Substituindo conteúdo de strings
string nomeCompleto = "Mauricio Roberto Gonzatto";
nomeCompleto = 
    nomeCompleto.Replace("Roberto", "Dalua");
Console.WriteLine(nomeCompleto);

// Comparação de strings
bool isNomeEqual = 
(nomeCompleto == "Mauricio Roberto Gonzatto");

bool isNomeEqual2 = 
    string.Equals(nomeCompleto, "Mauricio Dalua Gonzatto");

Console.WriteLine($"Primeiro resultado: {isNomeEqual}");
Console.WriteLine($"Segundo resultado: {isNomeEqual2}");

