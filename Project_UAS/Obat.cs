//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_UAS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Obat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Obat()
        {
            this.Transaksis = new HashSet<Transaksi>();
        }
    
        public string kode_obat { get; set; }
        public string nama_obat { get; set; }
        public Nullable<int> harga { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi> Transaksis { get; set; }
    }
}
