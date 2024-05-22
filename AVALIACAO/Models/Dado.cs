using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace AVALIACAO.Models
{
    internal class Dado
    {
        //PROP
        public int NumerodeLados { get; set; }
        public int NumeroSorteado { get; set; }

        public void Rolar()
        {
            NumeroSorteado = new Random().Next(NumerodeLados) + 1;
        }


        public Dado(int numerodeLados){
            NumerodeLados = numerodeLados;
        }

        public Dado()
        {
        }
    }
}
