//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsignacionEvento
    {
        public int idAsignacionEvento { get; set; }
        public int idEvento { get; set; }
        public int idAsigacionCatedratico { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> Finalizado { get; set; }
    }
}