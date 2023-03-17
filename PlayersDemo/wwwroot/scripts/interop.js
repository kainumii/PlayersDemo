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