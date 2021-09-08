using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class HistoricoAtendimento
    {
        public int AutoId { get; set; }
        public string NomeContato { get; set; }
        public long NumeroContato { get; set; }
        public string NomeChatbot { get; set; }
        public int NumeroTicket { get; set; }
        public string CanalOrigem { get; set; }
        public string TimeAtendimento { get; set; }
        public string AgenteAtendimento { get; set; }
        public DateTime DataHoraAbertura { get; set; }
        public DateTime DataHoraFechamento { get; set; }
        public string Tag { get; set; }
        public string EmailHistorico { get; set; }
    }
}
