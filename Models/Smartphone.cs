namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            try
            {
                Console.WriteLine("Ligando...");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message.ToString());
                Console.ReadLine();
            }
        }

        public void ReceberLigacao()
        {
            try
            {
                Console.WriteLine("Recebendo ligação...");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message.ToString());
                Console.ReadLine();
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}