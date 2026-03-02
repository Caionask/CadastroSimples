using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string name, mail = "";
        int age, option = 0;
        string[] users;
        int userkey = 0;

        Console.WriteLine("• WELCOME TO THE MAILHUB •");
        Console.WriteLine("Set '1' to Log in or '2' to subscribe");
        option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine("Your Mail: ");
                    mail = Console.ReadLine() ?? ""; // Nota 1.

                    if (string.IsNullOrWhiteSpace(mail)) // Nota 2.
                    {
                        Console.WriteLine("The mail adress cannot be empyt. Please, set a valid mail.");
                        continue;
                    }

                    if (!mail.Contains("@")) // Nota 3.
                    {
                        Console.WriteLine("Invalid mail, Try again.");
                        continue;
                    }

                }
                break;

            case 2:
            break;

            

        }
        
    }

    public static void WelcomeTerminal()
    {
        
    }
}

// Informações sobre o progresso do código e notas variadas:

// Nota 1: mail = Console.ReadLine() ?? ""; - O que isso representa?
/* minha variável foi declarada de uma forma que não pode armazenar um valor nulo, mas,
o ReadLine permite o retorno de um valor nulo pelo usuário, algo que geraria um conflito.

Ao acrescentar: (?? "") na frente do ReadLine eu garando que, se o retorno for nulo, a 
variável armazena uma string vazia.*/