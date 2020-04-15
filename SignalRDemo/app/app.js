
var app = angular.module("app", []);

app.run(function (signalR) {
    signalR.url("http://localhost:63288/signalr");
});