//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Playlister.dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Party
    {
        public Party()
        {
            this.People = new HashSet<Person>();
        }
    
        public int Party_ID { get; set; }
        public int Playlist { get; set; }
        public string Party_Title { get; set; }
        public int Participant_Count { get; set; }
        public string Genre_Limitation { get; set; }
        public Nullable<int> Repeat_Contraint { get; set; }
    
        public virtual Playlist Playlist1 { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}