//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public string marca { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public int idCategoria { get; set; }
        public bool esActivo { get; set; }
    
        public virtual Categorias Categorias { get; set; }
    }
}
