//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseMateService
{
    using System;
    using System.Collections.Generic;
    
    public partial class notice_board
    {
        public notice_board()
        {
            this.notices = new HashSet<notice>();
        }
    
        public int PK_noticeBoardID { get; set; }
        public int FK_houseID { get; set; }
    
        public virtual house house { get; set; }
        public virtual ICollection<notice> notices { get; set; }
    }
}
