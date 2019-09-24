using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Carro
    {
        public string Modelo;
        public string Cor;
        public int QuantidadeDePortas;
        public bool PossuiArCondicionado;

        public Carro()
        {
            Modelo = "Punto";
            Cor = "Preto";
            QuantidadeDePortas = 4;
            PossuiArCondicionado = true;
        }


        public string Ligar()
        {
            return "Carro Ligado !";
        }

        public string Desligar()
        {
            return "Carro Desligado !";
        }

        public string Detalhes()
        {
            return Modelo + " - " + Cor;
        }

    }
}
