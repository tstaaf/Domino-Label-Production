//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domino_Label_Production.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Orders1 = new ObservableCollection<Orders>();
        }
    
        public int Id { get; set; }
        public string TillverkningsOrderNummer { get; set; }
        public string KundNummer { get; set; }
        public string Leveransdatum { get; set; }
        public string AntalRulle { get; set; }
        public string Cylinder { get; set; }
        public string Stans { get; set; }
        public string Diameter { get; set; }
        public string ArtikelNummer { get; set; }
        public string ArtikelNamn { get; set; }
        public string RåMaterialNummer { get; set; }
        public string LotNr { get; set; }
        public Nullable<int> Order_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ObservableCollection<Orders> Orders1 { get; set; }
        public virtual Orders Orders2 { get; set; }
    }
}
