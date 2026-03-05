bool deveContinuar = true;
string historico = "";

while (deveContinuar == true)
{


    Console.WriteLine("----------------------------");
    Console.WriteLine("Calculadora, 2026!");
    Console.WriteLine("----------------------------");

    Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Tabuada\nH - Ver Histórico\nS - Sair");

    Console.WriteLine("Selecione a operação desejada: ");
    string operacaoSelecionada = Console.ReadLine();

    bool operacaoSelecionadaVazio = string.IsNullOrEmpty(operacaoSelecionada);

    if (operacaoSelecionadaVazio == true)
    {
        Console.WriteLine("Informe uma opção válida!");
        Console.ReadLine();

        continue;
    }
    if (operacaoSelecionada == "s" || operacaoSelecionada == "S")
    {
        deveContinuar = false;
        Console.WriteLine("Encerrando o programa. Até mais...");
        continue;
    }

    if (operacaoSelecionada == "h" || operacaoSelecionada == "h")
    {
        Console.WriteLine("Histórico de operações: ");
        Console.WriteLine(historico);
        Console.ReadLine();
        continue;
    }

    if (operacaoSelecionada == "5")
    {
        Console.WriteLine("Digite o número que deseja gerar a tabuada: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for (int contador = 1; contador <= 10; contador++)
        {
            int resultadoTabuada = numeroTabuada * contador;
            string operacaoTabuada = ($"{numeroTabuada} x {contador} = {resultadoTabuada}");

            Console.WriteLine(operacaoTabuada);
        }
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo número: \n");
    string strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine($"O primeiro número digitado foi: {strPrimeiroNumero}");
    Console.WriteLine($"O segundo número digitado foi: {strSegundoNumero}");

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
        Console.WriteLine("Digite um número válido!");
        Console.ReadLine();

        continue;
    }

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;
    string simbolo = "";
    switch (operacaoSelecionada)
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            simbolo = "+";
            break;
        case "2":
            resultado = primeiroNumero - segundoNumero;
            simbolo = "-";
            break;
        case "3":
            resultado = primeiroNumero * segundoNumero;
            simbolo = "*";
            break;
        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
                Console.ReadLine();
                continue;
            }
            resultado = primeiroNumero / segundoNumero;
            simbolo = "/";
            break;
        default:
            Console.WriteLine("Selecione uma operação válida!");

            continue;
    }

    string operacao = ($"{primeiroNumero} {simbolo} {segundoNumero} = {resultado}");

    historico += operacao + "\n";

    Console.WriteLine($"O resultado da operação é: {resultado}");

    Console.ReadLine();
}