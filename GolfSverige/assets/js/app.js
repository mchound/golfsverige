// Init google maps
function initialize() {
    var mapOptions = {
  		center: new google.maps.LatLng(62.835089, 15.820313),
  		zoom: 5,
  		mapTypeId: google.maps.MapTypeId.ROADMAP,
		panControl: false,
		zoomControl: false,
		mapTypeControl: false,
  		scaleControl: false,
  		streetViewControl: false,
  		overviewMapControl: false
    };
    var map = new google.maps.Map(document.getElementById("map-canvas"),
        mapOptions);
}
google.maps.event.addDomListener(window, 'load', initialize);

$(function () {

    $('div.nav div.menu-item').each(function (i, item) {
        $(this).css('min-width', $(this).outerWidth());
    });

    $('div.nav div.menu-item button.nav-button').click(function (e) {
        var $menuItem = $(this).parent(),
            $content = $menuItem.children('.nav-body');

        if (!$menuItem.hasClass('active')) {
            $menuItem.transition({ width: '50%' }, function () {
                $content.css('display', 'block').transition({
                    maxHeight: 1024,
                    height: 'auto'
                }, function () {
                    $menuItem.addClass('active');
                });
            });
        } else {
            $menuItem.removeClass('active');
            $content.transition({
                maxHeight: 0,
            }, function () {
                $content.css('display', 'none');
                $menuItem.transition({
                    width: 'initial'
                });
            });
        }
    });

    $('.check-buttons li button').click(function () {
        var $button = $(this);
        $button.toggleClass('checked');
    });
});
