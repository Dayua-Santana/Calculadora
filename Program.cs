// Requisito 1: Nossa calculadora deve permitir a soma de dois números
// Requisito 2: Nossa calculadora deve permitir a subtração de dois números
// Requisito 3: Nossa calculadora deve permitir a multiplicação de dois números
// Requisito 4: Nossa calculadora deve permitir a divisão de dois números

Console.Clear();

decimal resultado = 0;
bool deveContinuar = true; //atribuição

while (deveContinuar == true) //condição
{


    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Calculadora 2026!");
    Console.WriteLine("---------------------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("S - Sair");

    Console.Write("Selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;
        continue;
    }
    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O Primeiro numero digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O Segundo numero digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
        Console.Write("Digite um número válido: ");
        Console.ReadLine();

        continue;
    }

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);


    switch (operacaoSelecionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            break;
        case "3":
            resultado = primeiroNumero * segundoNumero;
            break;
        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possivel dividir por 0!!!");
                Console.ReadLine();
                continue;
            }

            resultado = primeiroNumero / segundoNumero;
            break;
        default:
            Console.WriteLine("Selecione uma operação válida: ");
            continue;

    }

    Console.WriteLine("A Operação dos dois números resulta em: " + resultado);

    Console.ReadLine();

}

