// Requisito 1: Nossa calculadora deve permitir a soma de dois números
// Requisito 2: Nossa calculadora deve permitir a subtração de dois números
// Requisito 3: Nossa calculadora deve permitir a multiplicação de dois números
// Requisito 4: Nossa calculadora deve permitir a divisão de dois números

List<string> historico = new List<string>();

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
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("H - Histórico de Operações");
    Console.WriteLine("S - Sair");

    Console.Write("Selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S" || operacaoSelecionada == "s")
    {
        deveContinuar = false;
        Console.Write("Progama encerrado!!");
        Console.ReadLine();
        break;
    }

    //lógica da tabuada
    if (operacaoSelecionada == "5")
    {
        Console.Write("Digite o número que deseja gerar a tabuada: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for (int contador = 1; contador <= 10; contador = contador + 1)
        {
            int resultadoTabuada = numeroTabuada * contador;
            string operacaoTabuada = $"{numeroTabuada} x {contador} = {resultadoTabuada}";
            Console.WriteLine(operacaoTabuada);
        }
        Console.ReadLine();
        continue;
    }

    if (operacaoSelecionada == "H" || operacaoSelecionada == "h")
    {
        Console.WriteLine("----- HISTÓRICO DE OPERAÇÕES -----");

        for (int i = 0; i < historico.Count; i++)
        {
            Console.WriteLine($"{i + 1} º Registro: {historico[i]}");
        }
        Console.ReadLine();
        continue;
    }
    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine($"O Primeiro numero digitado foi: {strPrimeiroNumero}");
    Console.WriteLine($"O Segundo numero digitado foi: {strSegundoNumero}");

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
        Console.Write("Digite um número válido: ");
        Console.WriteLine();

        continue;
    }

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

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
                Console.WriteLine("Não é possivel dividir por 0!!!");
                Console.ReadLine();
                continue;
            }

            resultado = primeiroNumero / segundoNumero;
            simbolo = "/";
            break;
        default:
            simbolo = "?";
            Console.WriteLine("Selecione uma operação válida: ");
            continue;


    }
    Console.WriteLine($"A Operação dos dois números resulta em: {resultado}");
    string linhaDohistorico = $"{primeiroNumero} {simbolo} {segundoNumero} = {resultado}";
    historico.Add(linhaDohistorico);

    Console.WriteLine("\nPressione Enter pra continuar...");
    Console.ReadLine();
}





