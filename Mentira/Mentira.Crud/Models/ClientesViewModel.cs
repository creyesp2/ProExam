using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mentira.Crud.Models
{
    public class ClientesViewModel
    {
        private ApplicationDbContext contexto;

        public ClientesViewModel()
        {
            contexto = new ApplicationDbContext();
            Clientes = new List<ClientesBusqueda>();
        }

        public List<ClientesBusqueda> Clientes { get; set; }

       

        public void BuscaPorNombre(string busqueda)
        {
            var consulta = from c in contexto.Clientes
                           where c.Nombre.Contains(busqueda)
                           select new
                           {
                               c.ClienteId,
                               c.RFC,
                               Tipo = c.Tipo.NombreTipo ?? "",
                               NombreCliente = c.Nombre,
                              
                           };
            Clientes.Clear();
            if (consulta != null)
            {
                var lclientes = consulta.ToList();
                foreach (var item in lclientes)
                {
                    Clientes.Add(new ClientesBusqueda
                    {
                        ClienteId = item.ClienteId,
                        Nombre = item.NombreCliente,
                     
                        RFC = item.RFC,
                        Tipo = item.Tipo
                        
                    });
                }
            }
        }

        


    }
}