// if (6 >= 3)
// {
//     Console.WriteLine("hello world");
// }


// Console.WriteLine("skriv ditt namn");
// string name = Console.ReadLine();
// Console.WriteLine("skriv ditt lösenord");
// string password = Console.ReadLine();

// if (name.ToLower() == "kalleanka" && password.ToLower() == "12345")
// {
//     Console.WriteLine("hola");
// } else
// {
//     Console.WriteLine("antingen så stämmer varken lösenord eller användarnamn");
// }

// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("hej världen");
// }




// Console.WriteLine("skriv användarnamn");
// string name = Console.ReadLine();

// string lösenord = "akejoiw";

// while(lösenord != "12345")
// {
// Console.WriteLine("Skriv lösenord");

// lösenord = Console.ReadLine();
// }
// Console.WriteLine("välkommen");


using System.Reflection.Metadata.Ecma335;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("skriv ett nummer ");
    string siffra = Console.ReadLine();
    int nummer;

    int.TryParse(siffra, out nummer);

    if (nummer > 5)
    {
        Console.WriteLine("större än 5");
    }
}



Console.ReadLine();