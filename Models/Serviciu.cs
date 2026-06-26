using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Serviciu
    {
        public int ServiciuId { get; set; }
        public string Denumire { get; set; }
        public decimal Pret { get; set; }
        public int Durata { get; set; } //in minute

    }
}
