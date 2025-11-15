class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo(7);
        Rectangulo rectangulo = new Rectangulo(3, 9);

        List<Forma> formas = new List<Forma>();
        formas.Add(circulo);
        formas.Add(rectangulo);

        foreach (var forma in formas)
        {
            Console.WriteLine($"Forma: {forma.Nombre} - Área: {forma.CalcularArea()}");
         }          
       }
    }