//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kormetal.Entities.Concrete
{
    using System;
    using System.Collections.Generic;
    
    public  class TBLILCELER
    {
        public TBLILCELER()
        {
            this.TBLBAYILER = new HashSet<TBLBAYILER>();
            this.TBLBAYILERLAS = new HashSet<TBLBAYILERLAS>();
        }
    
        public int ilceID { get; set; }
        public Nullable<int> ilID { get; set; }
        public string ilceAd { get; set; }
    
        public virtual ICollection<TBLBAYILER> TBLBAYILER { get; set; }
        public virtual ICollection<TBLBAYILERLAS> TBLBAYILERLAS { get; set; }
        public virtual TBLILLER TBLILLER { get; set; }
    }
}
