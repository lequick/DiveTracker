(function () {

    // Create an array of styles.
    var mapStyles = [{
        "featureType": "all",
        "elementType": "all",
        "stylers": [
            {
                "invert_lightness": true
            },
            {
                "saturation": 10
            },
            {
                "lightness": 30
            },
            {
                "gamma": 0.5
            },
            {
                "hue": "#435158"
            }
        ]
    },
        {
            "featureType": "landscape",
            "elementType": "geometry.fill",
            "stylers": [
                {
                    "color": "#14244a"
                }
            ]
        },
        {
            "featureType": "water",
            "elementType": "geometry.fill",
            "stylers": [
                {
                    "color": "#1a8dc1"
                }
            ]
        },
                                                   { //hide all fills
                                                       elementType: 'geometry.fill',
                                                       stylers: [
                                                           { visibility: 'off' }
                                                       ]
                                                   }, {
                                                       featureType: 'landscape.natural.landcover',
                                                       elementType: 'geometry.fill',
                                                       stylers: [
                                                           { visibility: 'on' },
                                                       ]
                                                   }
    ];

    // Create a map object, and include the MapTypeId to add
    // to the map type control.
    var mapOptions = {
        zoom: 6,
        center: new google.maps.LatLng(56.434003, 10.871666),
        styles: mapStyles,
        // The following line is essential for making the map background transparent:
        backgroundColor: 'hsla(0, 0%, 0%, 0)',
    };

    //create map object
    var map = new google.maps.Map(document.getElementById('map'), mapOptions);

})();
