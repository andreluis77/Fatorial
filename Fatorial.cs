public class Fatorial
{
    static int FatorialRecursivo(int Numero)
    {
        if (Numero > 1) return (Numero * FatorialRecursivo(Numero - 1));
        return Numero;
    }

    static int FatorialIterativo(int Numero)
    {
        int i = 1, Fatorial = 1;

        for (i = 1; i <= Numero; i++)
        {
            Fatorial *= i;
        }

        return Fatorial;
    }

    public static void Main()
    {
        int Numero = 1;
        string Escolha = " ";

        while (Numero != 0)
        {
            while (Escolha != "R" & Escolha != "I" & Escolha != "0")
            {
                Console.Write("Escolha (R)ecursivo ou (I)terativo (0 para sair): ");
                Escolha = Console.ReadLine();
                Escolha = Escolha.ToUpper();

                if (Escolha == "R")
                    Console.WriteLine("Função Recursiva será usada\n");

                if (Escolha == "I")
                    Console.WriteLine("Função Iterativa será usada\n");
            }

            if (Escolha != "0")
            {
                Console.Write("Informe um número entre 1 e 10 para calcular o fatorial (0 para sair): ");
                Numero = int.Parse(Console.ReadLine());

                if (Escolha == "R")
                {
                    // Recursivo
                    if (Numero > 0 & Numero < 11) Console.Write($"{Numero}! = {FatorialRecursivo(Numero)}\n\n\n");
                }
                else
                {
                    // Iterativo
                    if (Numero > 0 & Numero < 11) Console.Write($"{Numero}! = {FatorialIterativo(Numero)}\n\n\n");
                }
            }
            else Numero = 0;
        }
        Console.WriteLine("Fim de execução");
    }
}