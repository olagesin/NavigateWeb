using System.Device;
namespace ParvigateUIHelper
{
    public class Class1

    {

        public void GetCurrentGeolocation()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.Default);
            watcher.Start(); //started watcher
            GeoCoordinate coord = watcher.Position.Location;
            if (!watcher.Position.Location.IsUnknown)
            {
                double lat = coord.Latitude; //latitude
                double longg = coord.Longitude;  //logitude
            }
        }
    }
}