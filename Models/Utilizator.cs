using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Utilizator
    {
        public int UtilizatorId { get; set; }
        public string Nume { get; set; }
        public string Parola { get; set; }
        public Rol Rol { get; set; }

    }
    public enum Rol
    {
        Admin,
        Client,
        Angajat
    }
}
