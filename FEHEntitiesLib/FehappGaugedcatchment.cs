using System;
using System.Collections.Generic;

namespace FEHEntitiesLib
{
    public partial class FehappGaugedcatchment
    {
        public FehappGaugedcatchment()
        {
            FehappAmaxdata = new HashSet<FehappAmaxdata>();
        }

        public long Catchment { get; set; }
        public string Yeartype { get; set; }
        public string Wateryear { get; set; }
        public string AMrejected { get; set; }
        public string StName { get; set; }
        public string Loc { get; set; }
        public double? NomArea { get; set; }
        public long? NomNgre { get; set; }
        public long? NomNgrn { get; set; }
        public long? IHdtmngre { get; set; }
        public long? IHdtmngrn { get; set; }
        public long? CentroidNgre { get; set; }
        public long? CentroidNgrn { get; set; }
        public double? DTmarea { get; set; }
        public double? AltBar { get; set; }
        public double? AspBar { get; set; }
        public double? AspVar { get; set; }
        public double? BFihost { get; set; }
        public double? DPlbar { get; set; }
        public double? DPsbar { get; set; }
        public double? Farl { get; set; }
        public double? FPext { get; set; }
        public double? LDp { get; set; }
        public double? PropWet { get; set; }
        public double? Rmed1H { get; set; }
        public double? Rmed1D { get; set; }
        public double? Rmed2d { get; set; }
        public double? Saar { get; set; }
        public double? Saar4170 { get; set; }
        public double? SprHost { get; set; }
        public double? UrbConc1990 { get; set; }
        public double? UrbExt1990 { get; set; }
        public double? UrbLoc1990 { get; set; }
        public double? UrbConc2000 { get; set; }
        public double? UrbExt2000 { get; set; }
        public double? UrbLoc2000 { get; set; }
        public string SuitQmed { get; set; }
        public string SuitPooling { get; set; }
        public string StationComments { get; set; }
        public string CatchmentComments { get; set; }
        public string QmedComments { get; set; }
        public string PoolingComments { get; set; }

        public virtual ICollection<FehappAmaxdata> FehappAmaxdata { get; set; }
    }
}