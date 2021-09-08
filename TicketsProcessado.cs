using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class TicketsProcessado
    {
        public int AutoId { get; set; }
        public string NomeChatbot { get; set; }
        public int Ticket { get; set; }
        public DateTime Data { get; set; }
        public string KeyChatbot { get; set; }
    }
}
