//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace livenlup1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ToursBaseEntities : DbContext
    {

        private static ToursBaseEntities _context; 
        public ToursBaseEntities()
            : base("name=ToursBaseEntities")
        {
        }
        public static  ToursBaseEntities GetContext()
        {
            if (_context == null)
                _context = new ToursBaseEntities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<hotel> hotels { get; set; }
        public virtual DbSet<HotelCommnet> HotelCommnets { get; set; }
        public virtual DbSet<HotelImage> HotelImages { get; set; }
        public virtual DbSet<Tour_> Tour_ { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
