using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class NotaAtendimento
    {
        public int AutoId { get; set; }
        public string Valor { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime DataUpdate { get; set; }
        public DateTime DataAtendimento { get; set; }
    }
}
