//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserWorks
    {
        public long Id { get; set; }
        public long WorkId { get; set; }
        public long UserProfileId { get; set; }
        public System.DateTime StartingDate { get; set; }
        public int NoOfDays { get; set; }
        public string StatusText { get; set; }
    
        public virtual UserProfiles UserProfiles { get; set; }
        public virtual Works Works { get; set; }
    }
}
