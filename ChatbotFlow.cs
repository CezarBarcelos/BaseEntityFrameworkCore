using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class ChatbotFlow
    {
        public int AutoId { get; set; }
        public string NomeChatbot { get; set; }
        public DateTime DataBackup { get; set; }
        public DateTime DataUpdate { get; set; }
        public string Flow { get; set; }
    }
}
