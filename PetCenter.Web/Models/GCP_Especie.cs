//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetCenter.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GCP_Especie
    {
        public GCP_Especie()
        {
            this.GCP_Raza = new HashSet<GCP_Raza>();
        }
    
        public int CodigoEspecie { get; set; }
        public string DescripcionEspecie { get; set; }
    
        public virtual ICollection<GCP_Raza> GCP_Raza { get; set; }
    }
}
