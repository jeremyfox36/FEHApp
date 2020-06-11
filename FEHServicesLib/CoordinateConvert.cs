using GeoUK;
using GeoUK.Projections;
using GeoUK.Coordinates;
using GeoUK.Ellipsoids;

namespace FEHServicesLib
{
    public class CoordinateConvert
    {
        public (double latitude, double longitude) GeoUKConvert(double easting, double northing)
        {
            // Convert to Cartesian
            var cartesian = GeoUK.Convert.ToCartesian(new Airy1830(),
                    new BritishNationalGrid(),
                    new EastingNorthing(
                        easting,
                        northing));
            var wgsCartesian = Transform.Osgb36ToEtrs89(cartesian); //ETRS89 is effectively WGS84
            var wgsLatLong = GeoUK.Convert.ToLatitudeLongitude(new Wgs84(), wgsCartesian);
            return (wgsLatLong.Latitude, wgsLatLong.Longitude);
        }
    }
}
