//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gordeev_41.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Table
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int CourierId { get; set; }
        public int GoodId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime OrderReceivingDate { get; set; }
        public decimal OrderPrice { get; set; }
    }
}