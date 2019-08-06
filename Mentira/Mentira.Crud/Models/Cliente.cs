using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mentira.Crud.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public int TipoClienteId { get; set; }

        public TipoCliente Tipo { get; set; }

        public string RFC { get; set; }

        
    }
}