using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_SistemaDeCelular.Models
{
    public abstract class Smartphone
    {
         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria =memoria;
        }
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }
        public abstract void Ligar(string ligar);
        public abstract void ReceberLigacacao(string receber);
        public abstract void IntalarAplicativo(string nome);
    }
}