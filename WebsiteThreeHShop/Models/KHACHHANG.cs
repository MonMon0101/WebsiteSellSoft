//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteThreeHShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.CHATs = new HashSet<CHAT>();
            this.GIOHANGs = new HashSet<GIOHANG>();
            this.HOADONs = new HashSet<HOADON>();
            this.THANHTOANs = new HashSet<THANHTOAN>();
        }
    
        public int MAKH { get; set; }
        public string NAME { get; set; }
        public string GMAIL { get; set; }
        public string ADDRESS { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string PHONE { get; set; }
        public string AVATAR { get; set; }
        public Nullable<System.DateTime> TUOI { get; set; }
        public string GIOITINH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHAT> CHATs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THANHTOAN> THANHTOANs { get; set; }
    }
}
