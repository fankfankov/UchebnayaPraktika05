//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMONIC_Airlines.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedules
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public int AircraftID { get; set; }
        public int RouteID { get; set; }
        public decimal EconomyPrice { get; set; }
        public bool Confirmed { get; set; }
        public string FlightNumber { get; set; }
    
        public virtual Aircrafts Aircrafts { get; set; }
        public virtual Routes Routes { get; set; }
    }
}
