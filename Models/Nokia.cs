using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_SistemaDeCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            System.Console.WriteLine($"Numero:{numero} Modelo:{modelo} Imei:{imei} Memoria:{memoria}Gb");
        }
        public override void IntalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Instalando {nome}....");
        }

        public override void Ligar(string ligar)
        {
            System.Console.WriteLine($"ligando de.... \n{ligar}");
        }

        public override void ReceberLigacacao(string receber)
        {
            System.Console.WriteLine($"Recebendo ligacao de..... \n{receber}");
        }
    }
}