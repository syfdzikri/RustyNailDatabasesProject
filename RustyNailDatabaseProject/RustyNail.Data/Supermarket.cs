//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RustyNail.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supermarket
    {
        public Supermarket()
        {
            this.DailyReports = new HashSet<DailyReport>();
        }
    
        public int Id { get; set; }
        public string SupermarketName { get; set; }
    
        public virtual ICollection<DailyReport> DailyReports { get; set; }
    }
}