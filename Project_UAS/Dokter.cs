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
    
    public partial class Dokter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dokter()
        {
            this.Transaksis = new HashSet<Transaksi>();
        }
    
        public string kode_dokter { get; set; }
        public string nama_dokter { get; set; }
        public string alamat { get; set; }
        public string pendidikan { get; set; }
        public string no_telp { get; set; }
        public string spesialis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaksi> Transaksis { get; set; }
    }
}
