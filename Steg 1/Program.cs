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

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("skriv ett nummer ");
//     string siffra = Console.ReadLine();
//     int nummer;

//     int.TryParse(siffra, out nummer);

//     if (nummer > 5)
//     {
//         Console.WriteLine("större än 5");
//     }
// }

// bool success = false;

// while (!success)
// {
//     Console.WriteLine("skriv något, helst en siffra");
//     string skriv = Console.ReadLine();
//     int gababou;

//     success = int.TryParse(skriv, out gababou);

// }

int tal;
int tal2 = 0;
bool success;

tal = Random.Shared.Next(0, 100);

while (tal2 != tal)
{
    Console.WriteLine("gissa en siffra");
    string siffra = Console.ReadLine();

    success = int.TryParse(siffra, out tal2);

    if (success)
    {
        if (tal2 > tal)
        {
            Console.WriteLine("\ntalet är mindre,");
        } else if (tal2 < tal)
        {
            Console.WriteLine("\ntalet är större,");
        } else if (tal2 == tal)
        {
            Console.WriteLine("grattis du vann, är du glad nu eller?");
        }
    } else if (!success)
    {
        Console.WriteLine("\nsluta larva dig,");
    }
}


Console.ReadLine();