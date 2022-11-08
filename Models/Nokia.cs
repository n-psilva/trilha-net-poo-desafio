namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Abrindo Play Store...");
            Thread.Sleep(1300);
            Console.WriteLine($"Buscando o App {nomeApp}...");
            Thread.Sleep(1300);
            Console.WriteLine("Fazendo o download...");
            Console.Write("[");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write('■');
                Thread.Sleep(90);
            }
            Console.WriteLine("]");
            Console.WriteLine($"{nomeApp} instalado com sucesso!");
        }
    }
}