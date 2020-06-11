using Microsoft.VisualStudio.TestTools.UnitTesting;
using FEHServicesLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace FEHServicesLib.Tests
{
    [TestClass()]
    public class CoordinateConvertTests
    {
        [TestMethod()]
        public void ConvertGBNGRToLatLonTest()
        {
            var convert = new CoordinateConvert();
            var latLon = convert.GeoUKConvert(338595, 652173);
            //converted and rounded due to only having these OS NGR to lat lon 6 decimal places
            //the method returns lat lon to much higher precision
            decimal lat = decimal.Round((decimal)latLon.latitude,6);
            decimal lon = decimal.Round((decimal)latLon.longitude,6);
            
            Assert.AreEqual(lat, 55.758998M);
            Assert.AreEqual(lon, -2.980038M);
        }
    }
}