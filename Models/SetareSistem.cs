using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class SetareSistem
    {
        public int SetareSistemId { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string NumarTelefon { get; set; }
        public string ProgramSaptamana { get; set; }
        public string ProgramWeekend { get; set; }
    }
}
