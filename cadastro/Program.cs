using System;

string nome = string.Empty;
string email = string.Empty;
string nascimento = string.Empty;
string genero = string.Empty;
string CEP = string.Empty;
string Rua = string.Empty;
string Bairro = string.Empty;
string pais = string.Empty;
string uf = string.Empty;
string numero = string.Empty;
string cidade = string.Empty;


Console.WriteLine("Qual o seu nome");
nome = Console.ReadLine();
Console.WriteLine("Qual o seu E-mail");
email = Console.ReadLine();
Console.WriteLine("Sua data de Nascimento");
nascimento = Console.ReadLine();
Console.WriteLine("Qual o seu Genero");
genero = Console.ReadLine();
Console.WriteLine("\n Seu Endereço");
Console.WriteLine("Rua: ");
Rua = Console.ReadLine();
Console.WriteLine("CEP");
CEP = Console.ReadLine();
Console.WriteLine("Número");
numero = Console.ReadLine();
Console.WriteLine("Unidade Federatia");
uf = Console.ReadLine();
Console.WriteLine("Cidade");
cidade = Console.ReadLine();
Console.WriteLine("País");
pais = Console.ReadLine();
string resultado = $"Olá, {nome}, confirme seus dados: \n E-mail: {email} \n Gênero: {genero} \n Endereço: \n Rua: {Rua} \n CEP: {CEP} \n Numero: {numero} \n Unidade Federativa: {uf} \n Cidade: {cidade} \n País: {pais}  ";


Console.WriteLine(resultado);
