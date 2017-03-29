
function ff(allUsers) {
    var userNames = '';
    for (var i = 0; i < allUsers.length; i++) {
        userNames = userNames + '<button type="button" class="list-group-item">' + allUsers[i].Name + '</button>';
    }

    var r = '<div class="list-group">' + userNames + '</div>';
    $('#users').html(r);
}

$(function () {
    console.log('lol lol lol ...');

    var bsn = $.connection.businessHub;

    bsn.client.onConnected = function(id, userName, allUsers) {
        $('#header').html('There is ' + allUsers.length + ' users');
        ff(allUsers);
    }

    bsn.client.onUserDisconnected = function(allUsers) {
        $('#header').html('There is ' + allUsers.length + ' users');
        ff(allUsers);
    }

    bsn.client.updatePage = function () {
        window.location.reload(false);
        alert('Page was updated!');
    }


    $.connection.hub.start().done(function () {

        //$('#sendmessage').click(function () {
        //    // Вызываем у хаба метод Send
        //    chat.server.send($('#username').val(), $('#message').val());
        //    $('#message').val('');
        //});

        // обработка логина
        //$("#btnLogin").click(function () {

        //    var name = $("#txtUserName").val();
        //    if (name.length > 0) {
                //bsn.server.connect(name);
            //}
            //else {
            //    alert("Введите имя");
            //}
        //});
    });
})








    //            <style>
    //                #googleMap {
    //    width: 100%; /* Span the entire width of the screen */
    //    height: 500px; /* Set the height to 400 pixels */
    //                    /*-webkit-filter: grayscale(100%);*/
    //                    /*filter: grayscale(100%); /* Change the color of the map to black and white */*/
    //                }
    //</style>
    //<div id="googleMap"></div>
    //<!-- Add Google Maps -->
    //<script src="http://maps.googleapis.com/maps/api/js?libraries=places&key=AIzaSyCWrj0gM2DD0GVXXmjQihsxLIW5QB289Ok"></script>
    //<script>
                    
    //    // Standard google maps function
    //    function initialize() {
    //        // Create an array of styles.
    //        var styles = [{ "featureType": "water", "stylers": [{ "visibility": "on" }, { "color": "#b5cbe4" }] }, { "featureType": "landscape", "stylers": [{ "color": "#efefef" }] }, { "featureType": "road.highway", "elementType": "geometry", "stylers": [{ "color": "#83a5b0" }] }, { "featureType": "road.arterial", "elementType": "geometry", "stylers": [{ "color": "#bdcdd3" }] }, { "featureType": "road.local", "elementType": "geometry", "stylers": [{ "color": "#ffffff" }] }, { "featureType": "poi.park", "elementType": "geometry", "stylers": [{ "color": "#e3eed3" }] }, { "featureType": "administrative", "stylers": [{ "visibility": "on" }, { "lightness": 33 }] }, { "featureType": "road" }, { "featureType": "poi.park", "elementType": "labels", "stylers": [{ "visibility": "on" }, { "lightness": 20 }] }, {}, { "featureType": "road", "stylers": [{ "lightness": 20 }] }];

    //        // Create a new StyledMapType object, passing it the array of styles,
    //        // as well as the name to be displayed on the map type control.
    //        var styledMap = new google.maps.StyledMapType(styles, { name: "Styled Map" });

    //        var myLatlng = new google.maps.LatLng(48.12824, 17.12513);
    //        var myOptions = {
    //            zoom: 7,
    //            center: myLatlng,
    //            mapTypeControlOptions: {
    //                mapTypeIds: [google.maps.MapTypeId.ROADMAP, 'map_style']
    //            }
    //        }
                        
    //        map = new google.maps.Map(document.getElementById("googleMap"), myOptions);
    //        //Associate the styled map with the MapTypeId and set it to display.
    //        map.mapTypes.set('map_style', styledMap);
    //        map.setMapTypeId('map_style');

    //        TestMarker();
    //    }

    //var image = 'https://www.massageguys.com.au/img/map_marker.png';
    //// Function for adding a marker to the page.
    //function addMarker(location) {
    //    marker = new google.maps.Marker({
    //        position: location,
    //        map: map,
    //        icon: image
    //    });
    //}

    //// Testing the addMarker function
    //function TestMarker() {
    //    CentralPark = new google.maps.LatLng(37.7699298, -122.4469157);
    //    addMarker(CentralPark);
    //    CentralPark1 = new google.maps.LatLng(48.12824, 17.12513);
    //    addMarker(CentralPark1);
    //}

    //google.maps.event.addDomListener(window, 'load', initialize);
    //</script>
