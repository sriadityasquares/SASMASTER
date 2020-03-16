﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class salesDBEntities : DbContext
    {
        public salesDBEntities()
            : base("name=salesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCity> tblCities { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblProject> tblProjects { get; set; }
        public virtual DbSet<tblState> tblStates { get; set; }
        public virtual DbSet<tblTower> tblTowers { get; set; }
        public virtual DbSet<tblMonth> tblMonths { get; set; }
        public virtual DbSet<tblYear> tblYears { get; set; }
        public virtual DbSet<tblStatu> tblStatus { get; set; }
        public virtual DbSet<tblPaymentInfo> tblPaymentInfoes { get; set; }
        public virtual DbSet<tblLevelsMaster> tblLevelsMasters { get; set; }
        public virtual DbSet<tblSchemeMaster> tblSchemeMasters { get; set; }
        public virtual DbSet<tblAgentProjectLevel> tblAgentProjectLevels { get; set; }
        public virtual DbSet<tblAgentPaymentInfo> tblAgentPaymentInfoes { get; set; }
        public virtual DbSet<tblFlat> tblFlats { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<tblCustomerInfo> tblCustomerInfoes { get; set; }
        public virtual DbSet<tblBookingInformation> tblBookingInformations { get; set; }
        public virtual DbSet<tblAgentTotalPayment> tblAgentTotalPayments { get; set; }
        public virtual DbSet<tblAgentMaster> tblAgentMasters { get; set; }
        public virtual DbSet<tblFlatWiseAgentCommission> tblFlatWiseAgentCommissions { get; set; }
    
        public virtual ObjectResult<sp_GetFlatDetails_Result> sp_GetFlatDetails(Nullable<int> flatID, Nullable<int> projectID)
        {
            var flatIDParameter = flatID.HasValue ?
                new ObjectParameter("FlatID", flatID) :
                new ObjectParameter("FlatID", typeof(int));
    
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetFlatDetails_Result>("sp_GetFlatDetails", flatIDParameter, projectIDParameter);
        }
    
        public virtual ObjectResult<sp_GetPeriodWiseBookingDetails_Result> sp_GetPeriodWiseBookingDetails(Nullable<int> option, string project, string year, string month, string fromdate, string todate)
        {
            var optionParameter = option.HasValue ?
                new ObjectParameter("Option", option) :
                new ObjectParameter("Option", typeof(int));
    
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var yearParameter = year != null ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(string));
    
            var monthParameter = month != null ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(string));
    
            var fromdateParameter = fromdate != null ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(string));
    
            var todateParameter = todate != null ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetPeriodWiseBookingDetails_Result>("sp_GetPeriodWiseBookingDetails", optionParameter, projectParameter, yearParameter, monthParameter, fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<sp_getBookingInfoByDates_Result> sp_getBookingInfoByDates(string fromdate, string todate, string projectid)
        {
            var fromdateParameter = fromdate != null ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(string));
    
            var todateParameter = todate != null ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(string));
    
            var projectidParameter = projectid != null ?
                new ObjectParameter("projectid", projectid) :
                new ObjectParameter("projectid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getBookingInfoByDates_Result>("sp_getBookingInfoByDates", fromdateParameter, todateParameter, projectidParameter);
        }
    
        public virtual ObjectResult<sp_getPaymentInfoByDates_Result> sp_getPaymentInfoByDates(string fromdate, string todate, string projectid)
        {
            var fromdateParameter = fromdate != null ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(string));
    
            var todateParameter = todate != null ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(string));
    
            var projectidParameter = projectid != null ?
                new ObjectParameter("projectid", projectid) :
                new ObjectParameter("projectid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getPaymentInfoByDates_Result>("sp_getPaymentInfoByDates", fromdateParameter, todateParameter, projectidParameter);
        }
    
        public virtual ObjectResult<sp_GetTowerDetails_Result> sp_GetTowerDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetTowerDetails_Result>("sp_GetTowerDetails");
        }
    
        public virtual ObjectResult<sp_GetAgentWiseBookingDetails_Result> sp_GetAgentWiseBookingDetails(string project, string fromdate, string todate)
        {
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var fromdateParameter = fromdate != null ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(string));
    
            var todateParameter = todate != null ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAgentWiseBookingDetails_Result>("sp_GetAgentWiseBookingDetails", projectParameter, fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<sp_GetBhkWiseBookingDetails_Result> sp_GetBhkWiseBookingDetails(string project, string fromdate, string todate)
        {
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var fromdateParameter = fromdate != null ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(string));
    
            var todateParameter = todate != null ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetBhkWiseBookingDetails_Result>("sp_GetBhkWiseBookingDetails", projectParameter, fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<sp_GetFacingWiseBookingDetails_Result> sp_GetFacingWiseBookingDetails(string project, string fromdate, string todate)
        {
            var projectParameter = project != null ?
                new ObjectParameter("Project", project) :
                new ObjectParameter("Project", typeof(string));
    
            var fromdateParameter = fromdate != null ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(string));
    
            var todateParameter = todate != null ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetFacingWiseBookingDetails_Result>("sp_GetFacingWiseBookingDetails", projectParameter, fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<sp_GetAgentsByProjectID_Result> sp_GetAgentsByProjectID(Nullable<int> projectID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAgentsByProjectID_Result>("sp_GetAgentsByProjectID", projectIDParameter);
        }
    
        public virtual ObjectResult<sp_GetFlatWiseTotalAgentCommission_Result> sp_GetFlatWiseTotalAgentCommission(Nullable<int> projectID, Nullable<int> towerID)
        {
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            var towerIDParameter = towerID.HasValue ?
                new ObjectParameter("TowerID", towerID) :
                new ObjectParameter("TowerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetFlatWiseTotalAgentCommission_Result>("sp_GetFlatWiseTotalAgentCommission", projectIDParameter, towerIDParameter);
        }
    
        public virtual ObjectResult<sp_GetAgentCommissionByAgentLogin_Result> sp_GetAgentCommissionByAgentLogin(string agentEmail)
        {
            var agentEmailParameter = agentEmail != null ?
                new ObjectParameter("AgentEmail", agentEmail) :
                new ObjectParameter("AgentEmail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAgentCommissionByAgentLogin_Result>("sp_GetAgentCommissionByAgentLogin", agentEmailParameter);
        }
    
        public virtual ObjectResult<sp_GetAgentCommissionByAgentLogins_Result> sp_GetAgentCommissionByAgentLogins(string agentEmail)
        {
            var agentEmailParameter = agentEmail != null ?
                new ObjectParameter("AgentEmail", agentEmail) :
                new ObjectParameter("AgentEmail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAgentCommissionByAgentLogins_Result>("sp_GetAgentCommissionByAgentLogins", agentEmailParameter);
        }
    
        public virtual ObjectResult<sp_GetBookingDetails_Result> sp_GetBookingDetails(Nullable<int> flatID)
        {
            var flatIDParameter = flatID.HasValue ?
                new ObjectParameter("FlatID", flatID) :
                new ObjectParameter("FlatID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetBookingDetails_Result>("sp_GetBookingDetails", flatIDParameter);
        }
    
        public virtual ObjectResult<sp_GetFlatLifeCycle_Result> sp_GetFlatLifeCycle(Nullable<int> flatID)
        {
            var flatIDParameter = flatID.HasValue ?
                new ObjectParameter("FlatID", flatID) :
                new ObjectParameter("FlatID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetFlatLifeCycle_Result>("sp_GetFlatLifeCycle", flatIDParameter);
        }
    
        public virtual ObjectResult<sp_GetPercentages_Result> sp_GetPercentages()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetPercentages_Result>("sp_GetPercentages");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetAgentPayBalance(Nullable<int> agentID)
        {
            var agentIDParameter = agentID.HasValue ?
                new ObjectParameter("AgentID", agentID) :
                new ObjectParameter("AgentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetAgentPayBalance", agentIDParameter);
        }
    
        public virtual ObjectResult<sp_GetAgentLocations_Result> sp_GetAgentLocations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAgentLocations_Result>("sp_GetAgentLocations");
        }
    
        public virtual ObjectResult<sp_GetAgentCommissionNdBalanceByAgentLogins_Result> sp_GetAgentCommissionNdBalanceByAgentLogins(string agentEmail)
        {
            var agentEmailParameter = agentEmail != null ?
                new ObjectParameter("AgentEmail", agentEmail) :
                new ObjectParameter("AgentEmail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAgentCommissionNdBalanceByAgentLogins_Result>("sp_GetAgentCommissionNdBalanceByAgentLogins", agentEmailParameter);
        }
    }
}
