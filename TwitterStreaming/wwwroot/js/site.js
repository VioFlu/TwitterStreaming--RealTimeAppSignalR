"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/tweetHub").build();

//Disable send button until connection is established
//document.getElementById("sendButton").disabled = true;

connection.on("FilterPageTweets", function (filter) {
    var ul, li, a, i, txtValue;
    ul = document.getElementById("container");
    li = ul.getElementsByTagName("li");
    for (i = 0; i < li.length; i++) {
        a = li[i].getElementsByTagName("a")[0];
        txtValue = a.textContent || a.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            li[i].style.display = "";
        } else {
            li[i].style.display = "none";
        }
    }
});

connection.start().then(function () {
    //document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("myFilter").onkeyup = function (e) {
    if (e.keyCode === 13) {
        var input, filter;
        input = document.getElementById("myFilter");
        filter = input.value.toUpperCase();
        connection.invoke("FilterTweets", filter).catch(function (err) {
            return console.error(err.toString());
        });
        //event.preventDefault();
    }
};

