using DesafioPOO.Models;

try
{
    Nokia nokia = new Nokia("035978453698", "1100", "7954569745", 128);
    Iphone iphone = new Iphone("021988651345", "L2", "3657961547", 256);

    //Testes Nokia
    Console.WriteLine("Testes Nokia");
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Candy Crush Saga");

    //Testes Iphone
    Console.WriteLine("Testes Iphone");
    iphone.Ligar();
    iphone.ReceberLigacao();
    iphone.InstalarAplicativo("LikedIn");
}
catch (Exception erro)
{
    Console.WriteLine(erro.Message.ToString());
    Console.ReadLine();
}