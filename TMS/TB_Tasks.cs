//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Tasks
    {
        public int ID { get; set; }
        public Nullable<int> ID_Project { get; set; }
        public Nullable<int> ID_User { get; set; }
        public string Task_Name { get; set; }
        public string Task_Des { get; set; }
        public string Task_User { get; set; }
        public string Task_Admin { get; set; }
        public string Task_Project { get; set; }
        public Nullable<System.DateTime> Task_Start { get; set; }
        public Nullable<System.DateTime> Task_End { get; set; }
        public Nullable<int> Task_Duration { get; set; }
        public string Task_State { get; set; }
    
        public virtual TB_Projects TB_Projects { get; set; }
        public virtual TB_Users TB_Users { get; set; }
    }
}
