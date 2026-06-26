using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Raport
    {
        public int RaportId { get; set; }
        public string Descriere { get; set; }
        public DateTime DataGenerarii { get; set; } = DateTime.Now;
    }
}
