//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Home_Appliance_Store
{
    using System;
    using System.Collections.Generic;
    
    public partial class Т_Производитель
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Т_Производитель()
        {
            this.Т_Товар = new HashSet<Т_Товар>();
        }
    
        public int Код_Производителя { get; set; }
        public string Производитель { get; set; }
        public Nullable<short> Наценка { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Т_Товар> Т_Товар { get; set; }
    }
}
