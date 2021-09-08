using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Metrica
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime Data { get; set; }
        public int? UsuariosAtivos { get; set; }
        public int? UsuariosEngajados { get; set; }
        public int? QtdeMsgEnviadas { get; set; }
        public int? QtdeMsgRecebidas { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
