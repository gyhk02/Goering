//**************************************************************************
//Name: DB Class
//Author: T4
//Description: 该类由T4模板自动生成,,重新生成会覆盖该类,请不要在该类写代码！
//**************************************************************************
using System.Configuration;
using System.Data.Entity;
using Goering.Model.Models.EVN; 
using Goering.EFDAL.Mapping.EVN; 

namespace Goering.EFDAL.DB.EVN
{
	public partial class DBEntities : DbContext
    {
        
        //BeginDbSet
        public DbSet<TSUSERInfo> TSUSERs { get; set; }
		public DbSet<TNAPPLYFORInfo> TNAPPLYFORs { get; set; }
		public DbSet<TNEDUCATIONALREQUIREMENTSInfo> TNEDUCATIONALREQUIREMENTSs { get; set; }
		public DbSet<TNFLASHSCREENInfo> TNFLASHSCREENs { get; set; }
		public DbSet<TNJOBInfo> TNJOBs { get; set; }
		public DbSet<TNMONTHLYInfo> TNMONTHLYs { get; set; }
		public DbSet<TNNEWSInfo> TNNEWSs { get; set; }
		public DbSet<TNNEWSVIDEOInfo> TNNEWSVIDEOs { get; set; }
		public DbSet<TNWORKAREAInfo> TNWORKAREAs { get; set; }
		public DbSet<TRMENUUSERInfo> TRMENUUSERs { get; set; }
		public DbSet<TSMENUInfo> TSMENUs { get; set; }
		public DbSet<TNPROJECTInfo> TNPROJECTs { get; set; }
		public DbSet<TNSUBPROJECTInfo> TNSUBPROJECTs { get; set; }
        //EndDbSet
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //BeginBuilder
            modelBuilder.Configurations.Add(new TSUSERMap(true));
			modelBuilder.Configurations.Add(new TNAPPLYFORMap(true));
			modelBuilder.Configurations.Add(new TNEDUCATIONALREQUIREMENTSMap(true));
			modelBuilder.Configurations.Add(new TNFLASHSCREENMap(true));
			modelBuilder.Configurations.Add(new TNJOBMap(true));
			modelBuilder.Configurations.Add(new TNMONTHLYMap(true));
			modelBuilder.Configurations.Add(new TNNEWSMap(true));
			modelBuilder.Configurations.Add(new TNNEWSVIDEOMap(true));
			modelBuilder.Configurations.Add(new TNWORKAREAMap(true));
			modelBuilder.Configurations.Add(new TRMENUUSERMap(true));
			modelBuilder.Configurations.Add(new TSMENUMap(true));
			modelBuilder.Configurations.Add(new TNPROJECTMap(true));
			modelBuilder.Configurations.Add(new TNSUBPROJECTMap(true));
            //EndBuilder
        }
    }

}

