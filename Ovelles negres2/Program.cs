namespace Ovelles_negres2;

class Program
{
    static void Main(string[] args)
    {
        string[] ovelles =
        {
            "blanca",
            "negra",
            "blanca",
            "blanca",
            "negra",
            "blanca",
            "negra",
            "negra",
        };
        
        if (ovelles.Length % 2 != 0)
        {
            Console.WriteLine("Aquesta llista no està bé");
            return;
        }
        int totalOvellesNegras = 0;
        int totalOvellesBlanques = 0;
        int totalOvellesBlancasNegras = 0;
        
        for (int i = 0; i < ovelles.Length / 2; i++)
        {
            var primeravolta = ovelles[i];
            var segonavolta = ovelles[(ovelles.Length - 1) - i];
            if (primeravolta == segonavolta)
            {
                if (primeravolta == "negra")
                {
                    totalOvellesNegras++;
                }
                else if (primeravolta == "blanca")
                {
                    totalOvellesBlanques++;
                }
            }
            else if (primeravolta == "blanca" && segonavolta == "negra")
            {
                totalOvellesBlancasNegras++;
            }
        }
        Console.WriteLine($"Total ovelles negras: {totalOvellesNegras}");
        Console.WriteLine($"Total ovelles blanques: {totalOvellesBlanques}");
        Console.WriteLine($"Total ovelles blancas i negras: {totalOvellesBlancasNegras}");
    }
}
//balbalo 99