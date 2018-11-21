function myFunction() {
    var copyText = document.getElementById("myInput");

    copyText.select();

    document.execCommand("copy");

    var msg = document.getElementById('msg-clbp');

    msg.setAttribute("style", "display:block !important");
}