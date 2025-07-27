namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
            // Lógica específica para instalar o aplicativo no Nokia
            // Por exemplo, poderia haver uma verificação de compatibilidade ou algo do tipo
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia.");
        }
    }
}