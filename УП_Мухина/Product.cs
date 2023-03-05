//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace УП_Мухина
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.OrderProduct = new HashSet<OrderProduct>();
        }
    
        public string ProductArticleNumber { get; set; }
        public int ProductName { get; set; }
        public int ProductUnit { get; set; }
        public string ProductDescription { get; set; }
        public int ProductCategory { get; set; }
        public byte[] ProductPhoto { get; set; }
        public int ProductProvider { get; set; }
        public int ProductManufacturer { get; set; }
        public decimal ProductCost { get; set; }
        public Nullable<double> ProductDiscountAmount { get; set; }
        public Nullable<double> ProductDiscountMax { get; set; }
        public int ProductQuantityInStock { get; set; }
        public string ProductStatus { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual TitleProduct TitleProduct { get; set; }
        public virtual UnitOfMeasurement UnitOfMeasurement { get; set; }
    }
}
