public class Fatorial
{
    static int FatorialRecursivo(int Numero)
    {
        if (Numero > 1) return (Numero * FatorialRecursivo(Numero - 1));
        return Numero;
    }

    public static void Main(string[] args)
    {
        int Numero = 1;
        while (Numero != 0)
        {
            Console.Write("Informe um número entre 1 e 10 para calcular o fatorial (0 para sair): ");
            Numero  = int.Parse(Console.ReadLine());
            if (Numero > 0 & Numero < 11)Console.Write($"{Numero}! = {FatorialRecursivo(Numero)}\n\n\n");
        }
    }
}