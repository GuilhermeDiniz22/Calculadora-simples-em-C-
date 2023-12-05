Console.WriteLine("Olá Bem Vindo à calculadora em C#");
Console.WriteLine();

Console.WriteLine();

string escolha = "";

while (escolha != "F")
{
    if (escolha == "F")
    {
        Console.WriteLine("Fechando o programa");
        Environment.Exit(0);
    }

    Console.WriteLine("Digite o primeiro número: ");
    var num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo número: ");
    var num2 = int.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine("Escolha a operação desejada digitando a letra correspondente: ");
    Console.WriteLine();
    Console.WriteLine("[A]dicionar os números");
    Console.WriteLine("[S]ubtrair os números");
    Console.WriteLine("[M]ultiplicar os números");
    Console.WriteLine("[D]ividir os números");
    Console.WriteLine("[F]echar");
    Console.WriteLine();
    Console.WriteLine();
    escolha = Console.ReadLine().ToUpper();

   

    string operador = "";

    switch (escolha)
    {
        case "A":
            operador = "+";
            break;
        case "S":
            operador = "-";
            break;
        case "M":
            operador = "*";
            break;
        case "D":
            operador = "/";
            break;
        case "F":
            Console.WriteLine("Fechando o programa.");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Escolha inválida.");
            Environment.Exit(0);
            break;
    }

    Console.WriteLine();
    Console.WriteLine($"O resultado de {num1} {operador} {num2} é igual a: " + resultado());

    int resultado()
    {
        try
        {
            if (escolha == "A")
            {
                return somarNumeros(num1, num2);
            }
            else if (escolha == "S")
            {
                return subtrairNumeros(num1, num2);
            }
            else if (escolha == "M")
            {
                return multiplicarNumeros(num1, num2);
            }
            else if (escolha == "D")
            {
                return dividirNumeros(num1, num2);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw ex;

        }


        return 0;
    }

    int multiplicarNumeros(int n1, int n2)
    {
        return n1 * n2;
    }

    int subtrairNumeros(int n1, int n2)
    {
        return n1 - n2;
    }

    int dividirNumeros(int n1, int n2)
    {
        return n1 / n2;
    }

    int somarNumeros(int n1, int n2)
    {
        return n1 + n2;
    }
}

