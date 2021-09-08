using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class MensagensEnviada
    {
        public int AutoId { get; set; }
        public int Quantidade { get; set; }
        public DateTime IntervalStart { get; set; }
        public DateTime IntervalEnd { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime DataUpdate { get; set; }
    }
}
