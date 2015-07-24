using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApiExample.Models
{
    public class Localidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdProvincia { get; set; }
        public virtual Provincia Provincia { get; set; }
        public int Senasa_IdLoc { get; set; }
    }
}