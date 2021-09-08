using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Chatbot
    {
        public int AutoId { get; set; }
        public string NomeBase { get; set; }
        public string Nome { get; set; }
        public string Id { get; set; }
        public string AuthorizationKey { get; set; }
        public string RouterAuthorizationKey { get; set; }
        public int DateTimeOffSet { get; set; }
        public bool Router { get; set; }
        public bool AtendimentoHumano { get; set; }
        public bool Broadcast { get; set; }
        public string Nacionalidade { get; set; }
        public bool Report { get; set; }
        public string Grupo { get; set; }
    }
}
