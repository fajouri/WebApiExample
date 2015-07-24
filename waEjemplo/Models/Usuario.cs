using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApiExample.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefono { get; set; }
        public int TelefonoMovil { get; set; }
        public string Email { get; set; }
        public string ConfirmaEmail { get; set; }
        public string Cuil { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public Pais CodigoPais { get; set; }
        public Provincia CodigoProvincia { get; set; }
        public Localidad CodigoLocalidad { get; set; }
        public Boolean Newsletter { get; set; }
        public Boolean AceptaCondiciones { get; set; }
        public string Empresa { get; set; }
        public Cargo CodigoCargo { get; set; }
        public Sector CodigoSector { get; set; }
        public Boolean Validacion { get; set; }
        public Guid Token { get; set; }
    }
}