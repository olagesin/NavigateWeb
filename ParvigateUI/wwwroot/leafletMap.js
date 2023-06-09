export function load_map() {
    var map = L.map('map').setView([6.515805385300045, 3.3926725387573247], 16);

    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
    }).addTo(map);


    var popup = L.popup();
    console.log("something");
    function onMapClick(e) {
        DotNet.invokeMethodAsync("ParvigateUI",'HandleMapClick', e.latlng.lat, e.latlng.lng);
        popup
            .setLatLng(e.latlng)
            .setContent("You clicked the map at " + e.latlng.toString())
            .openOn(map);
    }

    map.on('click', onMapClick);

    return "";
}