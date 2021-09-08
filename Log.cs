using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Log
    {
        public int AutoId { get; set; }
        public string StackTrace { get; set; }
        public string Mensagem { get; set; }
        public string Aplicacao { get; set; }
        public string Metodo { get; set; }
        public string NomeChatbot { get; set; }
        public DateTime Data { get; set; }
        public string UsuarioLogin { get; set; }
    }
}
