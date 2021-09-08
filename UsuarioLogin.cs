using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class UsuarioLogin
    {
        public int AutoId { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Aplicacao { get; set; }
        public string Tipo { get; set; }
    }
}
