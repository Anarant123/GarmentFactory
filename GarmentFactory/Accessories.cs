//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GarmentFactory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accessories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessories()
        {
            this.Accessories_Product = new HashSet<Accessories_Product>();
            this.TypeAccessories = new HashSet<TypeAccessories>();
        }
    
        public string id { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public Nullable<double> Lenght { get; set; }
        public int Price { get; set; }
        public Nullable<int> Weight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accessories_Product> Accessories_Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeAccessories> TypeAccessories { get; set; }
    }
}
