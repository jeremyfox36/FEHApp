using System;
using System.Collections.Generic;

namespace FEHEntitiesLib
{
    public partial class FehappAmaxdata
    {
        public long Id { get; set; }
        public long CatchmentId { get; set; }
        public double Flow { get; set; }
        public string Mondate { get; set; }

        public virtual FehappGaugedcatchment Catchment { get; set; }
    }
}