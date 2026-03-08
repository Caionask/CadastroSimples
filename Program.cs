using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic; // Para uso de listas. 

class Program
{
    static void Main()
    {
        string mail = "";
        int age, option = 0;

        WelcomeTerminal();

        switch (option)
        {
            case 1:
                while (true)
                {
                    Console.WriteLine("Your Hero Mail: ");
                    mail = Console.ReadLine() ?? ""; // Nota 1.

                    if (string.IsNullOrWhiteSpace(mail) && !mail.Contains("@gmail.com")) // Nota 2.
                    {
                        Console.WriteLine("Please, set a valid mail.");
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
        Console.WriteLine("• WELCOME TO THE HERO MAILHUB •");
        Console.WriteLine("Set '1' to subscribe or '2' to Log in");
        int option = Convert.ToInt32(Console.ReadLine());
    }
}

// Informações sobre o progresso do código e notas variadas:

// Nota 1: mail = Console.ReadLine() ?? ""; - O que isso representa?
/* minha variável foi declarada de uma forma que não pode armazenar um valor nulo, mas,
o ReadLine permite o retorno de um valor nulo pelo usuário, algo que geraria um conflito.

Ao acrescentar: (?? "") na frente do ReadLine eu garando que, se o retorno for nulo, a 
variável armazena uma string vazia.*/

// Nota 2: "string.IsNullorWhiteSpace" - O que representa?
/* esse é um metodo usado para validação de variáveis do tipo string, ela verifica se
se o valor é nulo, vazio ou se há apenas espaços preenchidos e retorna verdade ou falso, 
dependendo do caso.*/

// Nota 3: 

