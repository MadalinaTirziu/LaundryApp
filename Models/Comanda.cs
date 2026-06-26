using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProiectMSOA.Models
{
    public class Comanda
    {
        public int ComandaId { get; set; }
        public int UtilizatorId { get; set; }
        public Utilizator Utilizator { get; set; }

        [NotMapped] 
        public string NumeClient
        {
            get
            {
                if (Utilizator != null)
                {
                    return Utilizator.Nume;
                }
                return "Necunoscut";
            }
        }
        public DateTime DataComenzii { get; set; } = DateTime.Now;
        public StatusComanda Status { get; set; }
        public List<Serviciu> ServiciiComandate  { get; set; } = new List<Serviciu>();
        public MetodaPlata MetodaPlata { get; set; }

    }
    public enum StatusComanda
    {
        InAsteptare,
        InProcesare,
        Finalizata,
        Anulata
    }

}
