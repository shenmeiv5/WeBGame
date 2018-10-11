var 精选_当前选项 = 0;
var 精选_选项 = document.body.getElementsByClassName("精选选项");
var 精选_面板集合 = document.body.getElementsByClassName("store_main_capsule");
var 精选_总计面板数 = 精选_面板集合.length;
var 是否滚动 = true;
function 精选_滚动() {
    //alert(allEleThumbs.length);
    setInterval(function () {
        //这个部分是精选跳转的类似代码,仅作为备份
        //let foc = document.body.getElementsByClassName("focus");
        ////alert(foc.length);
        //if (foc.length = 2) {
        //    foc[0].classList.remove("focus");
        //    nfoc[focnow].classList.add("focus");
        //    foc[1].classList.remove("focus");
        //    allEleThumbs[focnow].classList.add("focus");
        //}
        if (是否滚动) {
            精选_跳转到(精选_当前选项);
            精选_当前选项++;
            精选_当前选项 %= 精选_总计面板数;
        }
        //不论上次是否滚动,下次总应该重置滚动的flag
        是否滚动 = true;
    }, 10000 / 2);
}
//跳转到指定选项,同时暂停下一轮的滚动(便于onclick)
function 精选_跳转到(fnow) {
    精选_当前选项 = fnow;
    var foc = document.body.getElementsByClassName("focus");
    if (foc.length = 2) {
        foc[0].classList.remove("focus");
        精选_面板集合[fnow].classList.add("focus");
        foc[1].classList.remove("focus");
        精选_选项[fnow].classList.add("focus");
    }
    是否滚动 = false;
}
function 精选_当鼠标滑过时变更图片() {
    var foc = document.body.getElementsByClassName("focus");
    foc[0].getElementsByClassName("main_capsule");
}
精选_滚动();
//# sourceMappingURL=store.js.map