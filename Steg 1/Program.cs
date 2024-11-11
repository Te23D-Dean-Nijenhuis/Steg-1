// if (6 >= 3)
// {
//     Console.WriteLine("hello world");
// }

using System.Xml;

Console.WriteLine("skriv ditt namn");
string name = Console.ReadLine();
Console.WriteLine("skriv ditt lösenord");
string password = Console.ReadLine();

if (name.ToLower() == "kalleanka" && password.ToLower() == "12345")
{
    Console.WriteLine("hola");
} else
{
    Console.WriteLine("antingen så stämmer varken lösenorde eller användarnamn");
}



Console.ReadLine();