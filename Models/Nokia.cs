namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InfoSmartphone()
        {
            Console.WriteLine($"O seu Nokia é do modelo{Modelo}, tem {Memoria}GB de memoria. O Numero do chip é {Numero}, o número do IMEI é {IMEI}.");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Insatalando o {nomeApp} pela PlayStore");
        }

    }
}