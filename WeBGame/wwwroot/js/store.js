var 精选_当前选项 = 0;
var 精选_选项 = document.body.getElementsByClassName("精选选项");
var 精选_面板集合 = document.body.getElementsByClassName("store_main_capsule");
var 精选_总计面板数 = 精选_面板集合.length;
var 是否滚动 = true;
function 精选_初始化() {
    //在main_capsule类下的screenshot中插入鼠标滑入滑出事件
    //获取控件
    var info = document.body.getElementsByClassName("info");
    for (var k = 0; k < info.length; k++) {
        var screenshot = info[k].getElementsByClassName("screenshots");
        for (var i = 0; i < screenshot.length; i++) {
            var value = screenshot[i].getElementsByTagName("div");
            for (var j = 0; j < value.length; j++) {
                var value2 = value[j];
                //验证目标
                if (value2.attributes.length == 0) {
                    continue;
                }
                //定义属性
                var atr = document.createAttribute("onmouseover");
                atr.value = "精选_当鼠标滑过时变更图片(" + parseInt((j / 2).toString()) + ")";
                var atr2 = document.createAttribute("onmouseleave");
                atr2.value = "精选_当鼠标离开时取消图片(" + parseInt((j / 2).toString()) + ")";
                //添加控件
                value2.attributes.setNamedItem(atr);
                value2.attributes.setNamedItem(atr2);
            }
        }
    }
}
function 精选_滚动() {
    setInterval(function () {
        if (是否滚动) {
            精选_跳转到(精选_当前选项);
            精选_当前选项++;
            精选_当前选项 %= 精选_总计面板数;
        }
        //不论上次是否滚动,下次总应该重置滚动的flag
        //是否滚动 = true;
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
    //是否滚动 = false;
}
function 精选_当鼠标滑过时变更图片(eventHandler) {
    是否滚动 = false;
    {
        /*
        //let url1 = eventHandler.attributes.getNamedItem("data-background-image-url");
        //let url2 = eventHandler.attributes.getNamedItem("style");

        //let foc = document.body.getElementsByClassName("focus");
        //let mainCapsule = foc[0].getElementsByClassName("main_capsule")[0];

        //let atp = mainCapsule.attributes.getNamedItem("data-background-image-url");
        //atp.value = url1.value;
        //mainCapsule.attributes.setNamedItem(atp);

        //let style = mainCapsule.attributes.getNamedItem("style");
        //style.value = url2.value;
        //mainCapsule.attributes.setNamedItem(style);
        */
    } //弃用的方案,留做备案,这部分代码可以用来留作后端去调整内容url
    //新方法:通过在screenshot中添加focus来启用css的显示覆盖方案.
    //eventHandler.classList.add("focus");
    var focusEle = document.getElementsByClassName("focus")[0].getElementsByClassName("main_capsule")[0].getElementsByClassName("screenshot");
    focusEle[eventHandler].classList.add("focus");
}
function 精选_当鼠标离开时取消图片(eventHandler) {
    //let focusEle = document.getElementsByClassName("focus")[0].getElementsByClassName("main_capsule")[0].getElementsByClassName("screenshot");
    //focusEle[eventHandler].classList.remove("focus");
    document.getElementsByClassName("focus")[1].classList.remove("focus");
}
精选_初始化();
精选_滚动();
//# sourceMappingURL=store.js.map