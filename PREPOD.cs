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
    
    public partial class PREPOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PREPOD()
        {
            this.KURS = new HashSet<KURS>();
        }
    
        public int IdPREPOD { get; set; }
        public string Dis { get; set; }
        public string Napravlenie { get; set; }
        public string Time { get; set; }
        public string Mesto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KURS> KURS { get; set; }
    }
}
