//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GolfSverigeServer.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clubs
    {
        public Clubs()
        {
            this.Courses = new HashSet<Courses>();
        }
    
        public System.Guid GUID { get; set; }
        public Nullable<System.Guid> RegionGUID { get; set; }
        public string Name { get; set; }
        public Nullable<double> Lat { get; set; }
        public Nullable<double> Lon { get; set; }
    
        public virtual ICollection<Courses> Courses { get; set; }
        public virtual Districts Districts { get; set; }
    }
}