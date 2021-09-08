using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class BaseHumana
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime Data { get; set; }
        public string NomeContato { get; set; }
        public string Telefone { get; set; }
        public string NotaAtendimento { get; set; }
        public string Tag { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
