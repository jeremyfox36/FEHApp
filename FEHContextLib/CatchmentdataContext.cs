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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
