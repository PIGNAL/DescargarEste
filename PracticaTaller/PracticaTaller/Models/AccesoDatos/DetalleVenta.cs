//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticaTaller.Models.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public Nullable<int> idVenta { get; set; }
        public Nullable<int> idProducto { get; set; }
        public decimal Precio { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
