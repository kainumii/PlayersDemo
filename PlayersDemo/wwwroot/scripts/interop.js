// global scope
var interop = interop || {}

interop.showAlert = function (message) {
    alert(message)
};

interop.passObject = function (obj) {
    console.table(obj)
};

interop.returnsValue = function () {
    return "Best wishes from JavaScript!";
};

interop.objectAsReturnValue = function (etunimi, sukunimi, pelipaikka) {
    const player = { firstName: etunimi, lastName: sukunimi, isRight: true, position: pelipaikka };
    return player;
};

interop.focus = function (element) { 
    element.focus();
}

interop.CallStaticDotNetMethod = function () {
    var pr = DotNet.invokeMethodAsync("PlayersDemo", "BuildEmail", "Miikka");
    pr.then(email => alert(email));
}

interop.callDotNetInstanceMethod = function (ref) {
    console.log(ref);
    ref.invokeMethodAsync("SetWindowSize", {
        width: window.innerWidth,
        height: window.innerHeight
    })
}

interop.registerResizeHandler = function (ref) {
    function resizeHandler() {
        ref.invokeMethodAsync("SetWindowSize", {
            width: window.innerWidth,
            height: window.innerHeight
        })
    }

    resizeHandler();

    window.addEventListener("resize", resizeHandler);
}


interop.getLocation = function (ref) {
    //console.log("getLocation");

    //if (navigator.geolocation) {
    //    console.log("navigator.geolocation");
    //    navigator.geolocation.getCurrentPosition(function (position) {
    //        console.log("position");
    //        console.log(position.coords.latitude, position.coords.longitude);

    //        const coords = { latitude: 100 }
    //        return coords;
    //    });
    //}

    let coords;
    
    if (navigator.geolocation) {
       
        navigator.geolocation.getCurrentPosition(function (position) {
            console.log(position.coords.longitude);

            coords = { latitude: position.coords.latitude, longitude: position.coords.longitude }
            ref.invokeMethodAsync("SetCurrentGeolocation", coords);
            
        })        
    }
};

interop.registerOnlineHandler = function (ref) {
    function onlineHandler() {
        var onlineStatus = navigator.onLine;
        ref.invokeMethodAsync("SetOnline", onlineStatus)
    }

    onlineHandler();

    window.addEventListener("online", onlineHandler);
    window.addEventListener("offline", onlineHandler);
}
