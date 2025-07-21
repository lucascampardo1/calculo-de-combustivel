class Program
{
    public static void Main(string[] args)
    {
        static float combustivel(float gasolina, float etanol, string tipo) => tipo == "G" ? gasolina : etanol;
        static float indice(float gasolina, float etanol) => gasolina / etanol;

        Console.Write("Digite o valor da gasolina:");
        float gasolina = float.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o valor do etanol:");
        float etanol = float.Parse(Console.ReadLine() ?? "0");

        float indiceCombustivel = indice(gasolina, etanol);

        if (indiceCombustivel < 0.7)
        {
            Console.WriteLine("Compensa abastecer com etanol.");
        }
        else
        {
            Console.WriteLine("A gasolina é a melhor opção");
        }
    
    }
}