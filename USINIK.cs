//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KVANTORIUM
{
    using System;
    using System.Collections.Generic;
    
    public partial class USINIK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USINIK()
        {
            this.KURS = new HashSet<KURS>();
        }
    
        public int IdUSINIK { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Data { get; set; }
        public int Nomer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KURS> KURS { get; set; }
    }
}
