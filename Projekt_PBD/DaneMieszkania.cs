//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_PBD
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaneMieszkania
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaneMieszkania()
        {
            this.Bilans = new HashSet<Bilan>();
            this.Ofertas = new HashSet<Oferta>();
        }
    
        public int idM { get; set; }
        public Nullable<int> idW { get; set; }
        public Nullable<int> idK { get; set; }
        public string Miasto { get; set; }
        public string kodPocztowy { get; set; }
        public string Ulica { get; set; }
        public Nullable<int> nrBudynku { get; set; }
        public Nullable<int> nrMieszkania { get; set; }
        public Nullable<bool> doWynajecia { get; set; }
        public Nullable<bool> doRemontu { get; set; }
        public Nullable<decimal> kosztaRemontow { get; set; }
        public Nullable<System.DateTime> poczatekWynajmu { get; set; }
        public Nullable<System.DateTime> koniecWynajmu { get; set; }

        public override string ToString()
        {
            return $"{Miasto} {Ulica} {nrBudynku}/{nrMieszkania}";
        }

        public virtual Klient Klient { get; set; }
        public virtual Wlasciciel Wlasciciel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bilan> Bilans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oferta> Ofertas { get; set; }
    }
}
