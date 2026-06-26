using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Notificare
    {
        public int NotificareId { get; set; }
        public int UtilizatorId { get; set; }
        public Utilizator Utilizator { get; set; }
        public string Mesaj { get; set; }
        public DateTime DataNotificarii { get; set; }
    }
}
