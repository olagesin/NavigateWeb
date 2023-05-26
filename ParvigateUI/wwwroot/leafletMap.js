export function load_map() {
    //console.log(JSON.parse(String(rawJsonFile)));
    var map = L.map('map').setView([3.3923721313476567, 6.51951289080443], 13);

    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
    }).addTo(map);


    var popup = L.popup();

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