//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBookingInformation
    {
        public System.Guid BookingID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> TowerID { get; set; }
        public Nullable<int> FlatID { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<int> Bhk { get; set; }
        public Nullable<int> Area { get; set; }
        public string Facing { get; set; }
        public Nullable<int> SftRate { get; set; }
        public Nullable<int> HighRiseCharges { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<int> TotalRate { get; set; }
        public Nullable<int> FinalRate { get; set; }
        public Nullable<int> ClubHouseCharges { get; set; }
        public Nullable<int> GrandRate { get; set; }
        public string PaymentMode { get; set; }
        public string ReferenceNo { get; set; }
        public Nullable<int> BookingAmount { get; set; }
        public Nullable<int> BalanceAmount { get; set; }
        public Nullable<int> AgentID { get; set; }
        public Nullable<double> AgentComm { get; set; }
        public Nullable<double> SASComm { get; set; }
        public Nullable<double> SASTDS { get; set; }
        public Nullable<double> SASNet { get; set; }
        public Nullable<int> Aadhar { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ProjectName { get; set; }
        public string TowerName { get; set; }
        public string FlatName { get; set; }
        public string AgentName { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public Nullable<int> PaymentTimePeriod { get; set; }
        public Nullable<int> DownPaymentTimePeriod { get; set; }
        public Nullable<int> SchemeID { get; set; }
        public string SchemeName { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<double> AgentTDS { get; set; }
        public Nullable<double> AgentNet { get; set; }
        public Nullable<double> TotalComm { get; set; }
        public Nullable<int> PaymentModeID { get; set; }
        public string ChequeStatus { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
    }
}
