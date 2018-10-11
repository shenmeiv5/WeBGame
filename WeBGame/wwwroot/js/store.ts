let 精选_当前选项 = 0;
let 精选_选项 = document.body.getElementsByClassName("精选选项");
let 精选_面板集合 = document.body.getElementsByClassName("store_main_capsule");
let 精选_总计面板数 = 精选_面板集合.length;
let 是否滚动 = true;

function 精选_滚动() {
    //alert(allEleThumbs.length);

    setInterval(() => {
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
function 精选_跳转到(fnow: number) {
    精选_当前选项 = fnow;
    let foc = document.body.getElementsByClassName("focus");
    if (foc.length = 2) {
        foc[0].classList.remove("focus");
        精选_面板集合[fnow].classList.add("focus");
        foc[1].classList.remove("focus");
        精选_选项[fnow].classList.add("focus");
    }
    是否滚动 = false;
}

function 精选_当鼠标滑过时变更图片(eventHandler: Element) {

    let url1 = eventHandler.attributes.getNamedItem("data-background-image-url");
    let url2 = eventHandler.attributes.getNamedItem("style");

    let foc = document.body.getElementsByClassName("focus");
    let mainCapsule = foc[0].getElementsByClassName("main_capsule")[0];

    let atp = mainCapsule.attributes.getNamedItem("data-background-image-url");
    atp.value = url1.value;
    mainCapsule.attributes.setNamedItem(atp);

    let style = mainCapsule.attributes.getNamedItem("style");
    style.value = url2.value;
    mainCapsule.attributes.setNamedItem(style);
}

精选_滚动();