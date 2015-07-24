using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApiExample.Models
{

    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdBas { get; set; }
        public int Senasa_IdProv { get; set; }
        public List<Localidad> Localidades { get; set; }
    }
}