using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Atendente
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public string Nome { get; set; }
        public int? TicketsAbertos { get; set; }
        public int? TicketsFechados { get; set; }
        public string MediaTempoPrimeiraResposta { get; set; }
        public string MediaTempoEspera { get; set; }
        public string MediaTempoAtendimento { get; set; }
        public string MediaTempoResposta { get; set; }
        public DateTime PeriodoInicial { get; set; }
        public DateTime PeriodoFinal { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
