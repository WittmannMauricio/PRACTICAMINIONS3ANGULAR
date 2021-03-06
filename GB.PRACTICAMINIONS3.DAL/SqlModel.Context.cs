﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GB.PRACTICAMINIONS3.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BCR_PRACTICAMINIONS3Entities : DbContext
    {
        public BCR_PRACTICAMINIONS3Entities()
            : base("name=BCR_PRACTICAMINIONS3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Libros> Libros { get; set; }
    
        public virtual int PR_EliminarLibro(Nullable<int> piIdLibro, ObjectParameter piCodigo, ObjectParameter psMensaje)
        {
            var piIdLibroParameter = piIdLibro.HasValue ?
                new ObjectParameter("piIdLibro", piIdLibro) :
                new ObjectParameter("piIdLibro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_EliminarLibro", piIdLibroParameter, piCodigo, psMensaje);
        }
    
        public virtual int PR_InsertarLibros(string piCodigoLibro, string pvNombre, string pvAutor, Nullable<decimal> pvPrecio, string pvLink, ObjectParameter piCodigo, ObjectParameter psMensaje)
        {
            var piCodigoLibroParameter = piCodigoLibro != null ?
                new ObjectParameter("piCodigoLibro", piCodigoLibro) :
                new ObjectParameter("piCodigoLibro", typeof(string));
    
            var pvNombreParameter = pvNombre != null ?
                new ObjectParameter("pvNombre", pvNombre) :
                new ObjectParameter("pvNombre", typeof(string));
    
            var pvAutorParameter = pvAutor != null ?
                new ObjectParameter("pvAutor", pvAutor) :
                new ObjectParameter("pvAutor", typeof(string));
    
            var pvPrecioParameter = pvPrecio.HasValue ?
                new ObjectParameter("pvPrecio", pvPrecio) :
                new ObjectParameter("pvPrecio", typeof(decimal));
    
            var pvLinkParameter = pvLink != null ?
                new ObjectParameter("pvLink", pvLink) :
                new ObjectParameter("pvLink", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_InsertarLibros", piCodigoLibroParameter, pvNombreParameter, pvAutorParameter, pvPrecioParameter, pvLinkParameter, piCodigo, psMensaje);
        }
    
        public virtual ObjectResult<PR_MostrarLibros_Result> PR_MostrarLibros()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PR_MostrarLibros_Result>("PR_MostrarLibros");
        }
    
        public virtual int PR_ActualizarLibro(Nullable<int> piIdLibro, string pvCodigoLibro, string pvNombre, string pvAutor, Nullable<decimal> pmPrecio, string pvLinkAmazon, ObjectParameter piCodigo, ObjectParameter psMensaje)
        {
            var piIdLibroParameter = piIdLibro.HasValue ?
                new ObjectParameter("piIdLibro", piIdLibro) :
                new ObjectParameter("piIdLibro", typeof(int));
    
            var pvCodigoLibroParameter = pvCodigoLibro != null ?
                new ObjectParameter("pvCodigoLibro", pvCodigoLibro) :
                new ObjectParameter("pvCodigoLibro", typeof(string));
    
            var pvNombreParameter = pvNombre != null ?
                new ObjectParameter("pvNombre", pvNombre) :
                new ObjectParameter("pvNombre", typeof(string));
    
            var pvAutorParameter = pvAutor != null ?
                new ObjectParameter("pvAutor", pvAutor) :
                new ObjectParameter("pvAutor", typeof(string));
    
            var pmPrecioParameter = pmPrecio.HasValue ?
                new ObjectParameter("pmPrecio", pmPrecio) :
                new ObjectParameter("pmPrecio", typeof(decimal));
    
            var pvLinkAmazonParameter = pvLinkAmazon != null ?
                new ObjectParameter("pvLinkAmazon", pvLinkAmazon) :
                new ObjectParameter("pvLinkAmazon", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PR_ActualizarLibro", piIdLibroParameter, pvCodigoLibroParameter, pvNombreParameter, pvAutorParameter, pmPrecioParameter, pvLinkAmazonParameter, piCodigo, psMensaje);
        }
    }
}
