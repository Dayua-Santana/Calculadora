bool deveContinuar = true;
decimal resultado = 0; // CORREÇÃO 1: Declarada fora com valor inicial

while (deveContinuar)
{
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Calculadora 2026!");
    Console.WriteLine("---------------------------------------");

    Console.WriteLine("1 - Soma | 2 - Subtração | 3 - Multiplicação | 4 - Divisão| 5 - Tabuada | S - Sair");

    Console.Write("Selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine()?.ToUpper(); // ToUpper aceita 's' ou 'S'

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;
        break; // Sai do loop imediatamente
    }

    //lógica da tabuada
    if (operacaoSelecionada == "5")
    {
        Console.Write("Digite o número que deseja gerar a tabuada: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        //para cada
        // 1 Contador/ iterador
        // 2 Enquanto a condição for verdadeira executa o loop.....
        // 3 Interação da variavel contador
        for (int contador = 1; contador <= 10; contador = contador + 1)

        {
            int resultadoTabuada = numeroTabuada * contador;

            string operacaoTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;

            Console.WriteLine(operacaoTabuada);
        }

        Console.ReadLine();
        continue;
    }

    Console.Write("Digite o primeiro número: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    // Verificação de nulidade
    if (string.IsNullOrEmpty(strPrimeiroNumero) || string.IsNullOrEmpty(strSegundoNumero))
    {
        Console.WriteLine("Erro: preencha os números!");
        continue;
    }

    // Conversão (Dica: Use decimal.TryParse para ser mais seguro)
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
                continue; // CORREÇÃO 2: Volta ao menu em vez de fechar
            }
            resultado = primeiroNumero / segundoNumero;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            continue;
    }

    // CORREÇÃO 3: Exibe o resultado dentro do loop para o usuário ver
    Console.WriteLine($"\nO resultado é: {resultado}\n");
}

Console.WriteLine("Programa encerrado.");