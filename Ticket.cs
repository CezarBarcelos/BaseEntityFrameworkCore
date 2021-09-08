using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Ticket
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime Data { get; set; }
        public int? Aguardando { get; set; }
        public int? Abertos { get; set; }
        public int? Fechados { get; set; }
        public int? FechadosAtendente { get; set; }
        public int? FechadosContato { get; set; }
        public int? Transferidos { get; set; }
        public int? Perdidos { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
