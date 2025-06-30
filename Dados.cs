class Dados
{
    enum Dado
    {
        d4 = 1, d6 = 2, d8 = 3,
        d10 = 4, d20 = 5, d100 = 6
    }

    readonly int[] rolagens;
    private readonly int tipoDado;
    private readonly int qntdRolagem;
    private readonly int mod;
    private int res = 0;
    readonly Random random = new();

    public Dados(int tipoDado, int qntdRolagem, int mod)
    {
        this.tipoDado = tipoDado;
        this.qntdRolagem = qntdRolagem;
        this.mod = mod;

        rolagens = new int[this.qntdRolagem + 1];
    }

    public void Run()
    {
        Dado dado = (Dado)tipoDado;

        switch (dado)
        {
            case Dado.d4:
                RolarDados(4);
                break;
            case Dado.d6:
                RolarDados(6);
                break;
            case Dado.d8:
                RolarDados(8);
                break;
            case Dado.d10:
                RolarDados(10);
                break;
            case Dado.d20:
                RolarDados(20);
                break;
            case Dado.d100:
                RolarDados(100);
                break;
            default:
                Console.WriteLine("Tu fez alguma merda, tenta de novo >:(");
                Console.ReadLine();
                return;
        }

        EscreverResultado();
    }

    private void RolarDados(int rolagemMaxima)
    {
        for (int i = 0; i < qntdRolagem; i++)
        {
            int num = random.Next(1, rolagemMaxima + 1);

            res += num;
            rolagens[i] = num;
        }

        res += mod;
    }

    private void EscreverResultado()
    {
        string texto = "";

        texto += $"{rolagens[0]}";

        for (int i = 1; i < qntdRolagem; i++)
        {
            texto += $" + {rolagens[i]}";
        }

        texto += $" + {mod} = {res}";

        Console.WriteLine($"Resultado: {texto}");
        Console.ReadLine();
    }
}
