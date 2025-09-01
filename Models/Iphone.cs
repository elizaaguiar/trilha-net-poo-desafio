namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // DONE
    public class Iphone : Smartphone
    {   
        public Iphone(string numero, string modelo, string IMEI, int memoria) { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // DONE
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        }
    }
}