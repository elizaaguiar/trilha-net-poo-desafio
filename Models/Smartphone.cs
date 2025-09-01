namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone() { }
        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _IMEI = IMEI;
            _memoria = memoria;
        }
        public string Numero { get; set; }
        private string _modelo { get; set; }
        private string _IMEI { get; set; }
        private int _memoria { get; set; }

        public string Modelo
        {
            set
            {
                _modelo = value;
            }
        }
         public string IMEI
        {
            set
            {
                _IMEI = value;
            }
        }
         public int Memoria
        {
            set
            {
                _memoria = value;
            }
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}