var focnow = 0;
function 精选滚动() {
    //let foc = document.body.getElementsByClassName("focus");
    var nfoc = document.body.getElementsByClassName("store_main_capsule");
    var ca = document.body.getElementsByTagName("a class");
    var fcount = nfoc.length;
    //document.body.getElementsByClassName("test")[0].innerHTML += nfoc.length;
    var timer = 1500;
    setTimeout(function () {
        var foc = document.body.getElementsByClassName("focus");
        //let nfoc = document.body.getElementsByClassName("store_main_capsule broadcast_capsule app_impression_tracked");
        foc[0].classList.remove("focus");
        nfoc[focnow].classList.add("focus");
        focnow++;
        focnow %= fcount;
        timer = 1500;
    }, timer);
}
精选滚动();
//# sourceMappingURL=store.js.map