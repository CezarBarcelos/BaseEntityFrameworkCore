using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PortalCNHContext portalCNHContext = new PortalCNHContext();
            
             //Contato contato = new Contato();
             //contato.Marca = "CASE CE";
             //contato.Nome = "BAHAMUT";
             //contato.Telefone = "55319999999999";
             //contato.Acesso = DateTime.Now;
             //contato.AutoId = 11452;
             //contato.DataUpdate = DateTime.Now;
            var con = portalCNHContext.Contatos.Where(e => e.DataUpdate > DateTime.Now.AddDays(-50)).ToList();

            foreach (Contato item in con)
            {
                Console.WriteLine(item.Nome);
            }            
        }
    }
}
