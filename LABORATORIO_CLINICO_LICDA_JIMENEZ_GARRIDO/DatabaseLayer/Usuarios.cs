//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public Usuarios()
        {
            this.Resultados = new HashSet<Resultados>();
            this.Resultados1 = new HashSet<Resultados>();
        }
    
        public int Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre_Completo { get; set; }
        public string Correo { get; set; }
        public int Tipo_Usuario { get; set; }
    
        public virtual ICollection<Resultados> Resultados { get; set; }
        public virtual ICollection<Resultados> Resultados1 { get; set; }
        public virtual Tipo_Usuarios Tipo_Usuarios { get; set; }
    }
}
