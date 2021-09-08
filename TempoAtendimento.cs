using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class TempoAtendimento
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public string TempoAtendimento1 { get; set; }
        public DateTime PeriodoInicial { get; set; }
        public DateTime PeriodoFinal { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
