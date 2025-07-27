using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone meuNokia = new Nokia("123456789", "Modelo Nokia", "Versão 1.0", 64);
        Smartphone meuIphone = new Iphone("987654321", "Modelo iPhone", "Versão 2.0", 256);

        Console.WriteLine("Instalando aplicativos nos smartphones:");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine("Instalando aplicativos no iPhone:");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");
    }   
}