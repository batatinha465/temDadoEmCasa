class Program
{
    static void Main()
    {
        Console.Clear();

        int tipoDado, qntdRolagem, mod;

        try
        {
            Console.WriteLine("Dados:");
            Console.WriteLine("\n1 - D4, 2 - D6, 3 - D8,\n4 - D10, 5 - D20, 6 - D100");
            Console.Write("\nDigite o número do dado que quer escolher: ");
            tipoDado = int.Parse(Console.ReadLine()!);

            if (tipoDado < 1 || tipoDado > 7)
            {
                Console.WriteLine("Você sabe ler? Tenta de novo >:(");
                Console.ReadLine();
                return;
            }

            Console.Write("Quantos dados: ");
            qntdRolagem = int.Parse(Console.ReadLine()!);
            
            if (qntdRolagem < 1)
            {
                Console.WriteLine("Tá rodando dado hipotético fdp? Tenta de novo >:(");
                Console.ReadLine();
                return;
            }

            Console.Write("Modificador: ");
            mod = int.Parse(Console.ReadLine()!);

            Dados dados = new(tipoDado, qntdRolagem, mod);
            dados.Run();
        }
        catch
        {
            Console.WriteLine("Tu fez alguma merda, tenta de novo >:(");
            Console.ReadLine();
            return;
        }
    }
}
