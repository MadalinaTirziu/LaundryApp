using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Plata
    {
        public int PlataId { get; set; }
        public int ComandaId { get; set; }
        public Comanda Comanda { get; set; }
        public decimal Suma { get; set; }
        public DateTime DataPlatii { get; set; }
        public MetodaPlata Metoda { get; set; }
    }
    public enum MetodaPlata
    {
        Card,
        Cash
    }
}
