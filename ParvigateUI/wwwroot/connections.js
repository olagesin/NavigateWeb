export function connectionFunctions() {
    window.calculateDistance = function (sourceLatitude, sourceLongitutde, destinationoLatitude, destinationoLongitude) {
        var sourceLocation = L.latLng(sourceLatitude, sourceLongitutde);
        var destinationLocation = L.latLng(destinationoLatitude, destinationoLongitude);
        var distanceInMeters = sourceLocation.distanceTo(destinationLocation);
        return distanceInMeters;
    };

    return "";
}