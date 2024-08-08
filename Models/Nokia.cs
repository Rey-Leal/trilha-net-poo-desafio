namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                Console.WriteLine("Instalando aplicativo Nokia...");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}