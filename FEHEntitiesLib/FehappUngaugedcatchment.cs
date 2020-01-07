using System;
using System.Collections.Generic;

namespace FEHApp.Shared
{
    public partial class FehappUngaugedcatchment
    {
        public long Id { get; set; }
        public string CatchmentName { get; set; }
        public string Version { get; set; }
        public long Centroid { get; set; }
        public long CentroidE { get; set; }
        public long CentroidN { get; set; }
        public double Area { get; set; }
        public double Altbar { get; set; }
        public double Aspbar { get; set; }
        public double Aspvar { get; set; }
        public double Bfihost { get; set; }
        public double Dplbar { get; set; }
        public double Dpsbar { get; set; }
        public double Farl { get; set; }
        public double Fpext { get; set; }
        public double Fpdbar { get; set; }
        public double Fploc { get; set; }
        public double Ldp { get; set; }
        public double Propwet { get; set; }
        public double Rmed1h { get; set; }
        public double Rmed1d { get; set; }
        public double Rmed2d { get; set; }
        public double Saar { get; set; }
        public double Saar4170 { get; set; }
        public double Sprhost { get; set; }
        public double Urbconc1990 { get; set; }
        public double Urbext1990 { get; set; }
        public double Urbloc1990 { get; set; }
        public double Urbconc2000 { get; set; }
        public double Urbext2000 { get; set; }
        public double Urbloc2000 { get; set; }
        public double C { get; set; }
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double D3 { get; set; }
        public double E { get; set; }
        public double F { get; set; }
        public double C1km { get; set; }
        public double D11km { get; set; }
        public double D21km { get; set; }
        public double D31km { get; set; }
        public double E1km { get; set; }
        public double F1km { get; set; }
        public long UserId { get; set; }
    }
}
