//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Template.Models.Template
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public System.Guid Id_usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public Nullable<System.Guid> IdPregunta { get; set; }
        public string Respuesta { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }
        public string Contraseña { get; set; }
        public string Salt { get; set; }
        public bool Estado { get; set; }
    }
}
