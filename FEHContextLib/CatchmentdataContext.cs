using Microsoft.EntityFrameworkCore;

namespace FEHApp.Shared
{
    public partial class CatchmentdataContext : DbContext
    {
        public CatchmentdataContext()
        {
        }

        public CatchmentdataContext(DbContextOptions<CatchmentdataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<FehappAmaxdata> FehappAmaxdata { get; set; }
        public virtual DbSet<FehappGaugedcatchment> FehappGaugedcatchment { get; set; }
        public virtual DbSet<FehappUngaugedcatchment> FehappUngaugedcatchment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<FehappAmaxdata>(entity =>
            {
                entity.ToTable("FEHApp_amaxdata");

                entity.HasIndex(e => e.CatchmentId)
                    .HasName("FEHApp_amaxdata_catchment_id_1d6cad25");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatchmentId).HasColumnName("catchmentId");

                entity.Property(e => e.Flow).HasColumnName("flow");

                entity.Property(e => e.Mondate)
                    .IsRequired()
                    .HasColumnName("mondate")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.Catchment)
                    .WithMany(p => p.FehappAmaxdata)
                    .HasForeignKey(d => d.CatchmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<FehappGaugedcatchment>(entity =>
            {
                entity.HasKey(e => e.Catchment);

                entity.ToTable("FEHApp_gaugedcatchment");

                entity.Property(e => e.Catchment)
                    .HasColumnName("catchment")
                    .ValueGeneratedNever();

                entity.Property(e => e.AMrejected)
                    .IsRequired()
                    .HasColumnName("aMRejected")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.AltBar).HasColumnName("altBar");

                entity.Property(e => e.AspBar).HasColumnName("aspBar");

                entity.Property(e => e.AspVar).HasColumnName("aspVar");

                entity.Property(e => e.BFihost).HasColumnName("bFIHost");

                entity.Property(e => e.CatchmentComments)
                    .HasColumnName("catchment_comments")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.CentroidNgre).HasColumnName("centroidNGRE");

                entity.Property(e => e.CentroidNgrn).HasColumnName("centroidNGRN");

                entity.Property(e => e.DPlbar).HasColumnName("dPLBar");

                entity.Property(e => e.DPsbar).HasColumnName("dPSBar");

                entity.Property(e => e.DTmarea).HasColumnName("dTMArea");

                entity.Property(e => e.FPext).HasColumnName("fPExt");

                entity.Property(e => e.Farl).HasColumnName("farl");

                entity.Property(e => e.IHdtmngre).HasColumnName("iHDTMNGRE");

                entity.Property(e => e.IHdtmngrn).HasColumnName("iHDTMNGRN");

                entity.Property(e => e.LDp).HasColumnName("lDP");

                entity.Property(e => e.Loc)
                    .IsRequired()
                    .HasColumnName("loc")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NomArea).HasColumnName("nomArea");

                entity.Property(e => e.NomNgre).HasColumnName("nomNGRE");

                entity.Property(e => e.NomNgrn).HasColumnName("nomNGRN");

                entity.Property(e => e.PoolingComments)
                    .HasColumnName("pooling_comments")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.PropWet).HasColumnName("propWet");

                entity.Property(e => e.QmedComments)
                    .HasColumnName("qmed_comments")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.Rmed1D).HasColumnName("rmed1D");

                entity.Property(e => e.Rmed1H).HasColumnName("rmed1H");

                entity.Property(e => e.Rmed2d).HasColumnName("rmed_2D");

                entity.Property(e => e.Saar).HasColumnName("saar");

                entity.Property(e => e.Saar4170).HasColumnName("saar4170");

                entity.Property(e => e.SprHost).HasColumnName("sprHost");

                entity.Property(e => e.StName)
                    .IsRequired()
                    .HasColumnName("stName")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.StationComments)
                    .HasColumnName("station_comments")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.SuitPooling)
                    .HasColumnName("suitPooling")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.SuitQmed)
                    .HasColumnName("suitQMED")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.UrbConc1990).HasColumnName("urbConc1990");

                entity.Property(e => e.UrbConc2000).HasColumnName("urbConc2000");

                entity.Property(e => e.UrbExt1990).HasColumnName("urbExt1990");

                entity.Property(e => e.UrbExt2000).HasColumnName("urbExt2000");

                entity.Property(e => e.UrbLoc1990).HasColumnName("urbLoc1990");

                entity.Property(e => e.UrbLoc2000).HasColumnName("urbLoc2000");

                entity.Property(e => e.Wateryear)
                    .IsRequired()
                    .HasColumnName("wateryear")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Yeartype)
                    .IsRequired()
                    .HasColumnName("yeartype")
                    .HasColumnType("varchar(20)");
            });
            modelBuilder.Entity<FehappUngaugedcatchment>(entity =>
            {
                entity.ToTable("FEHApp_ungaugedcatchment");

                entity.HasIndex(e => e.UserId)
                    .HasName("FEHApp_ungaugedcatchment_user_id_677a73d5");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Altbar).HasColumnName("altbar");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Aspbar).HasColumnName("aspbar");

                entity.Property(e => e.Aspvar).HasColumnName("aspvar");

                entity.Property(e => e.Bfihost).HasColumnName("bfihost");

                entity.Property(e => e.C).HasColumnName("c");

                entity.Property(e => e.C1km).HasColumnName("c_1km");

                entity.Property(e => e.CatchmentName)
                    .IsRequired()
                    .HasColumnName("catchment_name")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Centroid).HasColumnName("centroid");

                entity.Property(e => e.CentroidE).HasColumnName("centroid_e");

                entity.Property(e => e.CentroidN).HasColumnName("centroid_n");

                entity.Property(e => e.D1).HasColumnName("d1");

                entity.Property(e => e.D11km).HasColumnName("d1_1km");

                entity.Property(e => e.D2).HasColumnName("d2");

                entity.Property(e => e.D21km).HasColumnName("d2_1km");

                entity.Property(e => e.D3).HasColumnName("d3");

                entity.Property(e => e.D31km).HasColumnName("d3_1km");

                entity.Property(e => e.Dplbar).HasColumnName("dplbar");

                entity.Property(e => e.Dpsbar).HasColumnName("dpsbar");

                entity.Property(e => e.E).HasColumnName("e");

                entity.Property(e => e.E1km).HasColumnName("e_1km");

                entity.Property(e => e.F).HasColumnName("f");

                entity.Property(e => e.F1km).HasColumnName("f_1km");

                entity.Property(e => e.Farl).HasColumnName("farl");

                entity.Property(e => e.Fpdbar).HasColumnName("fpdbar");

                entity.Property(e => e.Fpext).HasColumnName("fpext");

                entity.Property(e => e.Fploc).HasColumnName("fploc");

                entity.Property(e => e.Ldp).HasColumnName("ldp");

                entity.Property(e => e.Propwet).HasColumnName("propwet");

                entity.Property(e => e.Rmed1d).HasColumnName("rmed_1d");

                entity.Property(e => e.Rmed1h).HasColumnName("rmed_1h");

                entity.Property(e => e.Rmed2d).HasColumnName("rmed_2d");

                entity.Property(e => e.Saar).HasColumnName("saar");

                entity.Property(e => e.Saar4170).HasColumnName("saar4170");

                entity.Property(e => e.Sprhost).HasColumnName("sprhost");

                entity.Property(e => e.Urbconc1990).HasColumnName("urbconc1990");

                entity.Property(e => e.Urbconc2000).HasColumnName("urbconc2000");

                entity.Property(e => e.Urbext1990).HasColumnName("urbext1990");

                entity.Property(e => e.Urbext2000).HasColumnName("urbext2000");

                entity.Property(e => e.Urbloc1990).HasColumnName("urbloc1990");

                entity.Property(e => e.Urbloc2000).HasColumnName("urbloc2000");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("varchar(5)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
