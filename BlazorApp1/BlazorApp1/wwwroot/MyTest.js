function Show() {
    window.alert();
}

function MouseOver(pos) {
    document.getElementById("pos" + pos).style.background = "antiquewhite";
}
function MouseOut(pos) {
    document.getElementById("pos" + pos).style.background = "darkgray";
}

//var MyPos;
function PosClick(pos) {
    //document.getElementById("pos" + pos).style.background = "antiquewhite";
     MyPos = "pos" + pos;
}

function DragCompleted(pos) {
    document.getElementById("pos_order").value = pos;
    //window.alert("haha");
}
function sortable(rootEl, onUpdate) {
    var dragEl;

    // 将所有的子类元素设置为可拖动的  draggable = true
    [].slice.call(rootEl.children).forEach(function (itemEl) {
        itemEl.draggable = true;
    });

    // 该函数负责进行排序
    function _onDragOver(evt) {
        evt.preventDefault();
        evt.dataTransfer.dropEffect = 'move';

        var target = evt.target;
        if (target && target !== dragEl && target.nodeName == 'LI') {
            // Sorting
            rootEl.insertBefore(dragEl, target.nextSibling || target);
        }
    }

    // 排序结束后的钩子函数
    function _onDragEnd(evt) {
        evt.preventDefault();

        dragEl.classList.remove('ghost');
        rootEl.removeEventListener('dragover', _onDragOver, false);
        rootEl.removeEventListener('dragend', _onDragEnd, false);

        onUpdate(dragEl);
    }

    // 开始排序  监听父元素的dragstart 事件
    rootEl.addEventListener('dragstart', function (evt) {
        // 保存当前被拖动的子元素
        dragEl = evt.target;

        // 设置移动的类型
        evt.dataTransfer.effectAllowed = 'move';
        // 设置要移动的数据
        evt.dataTransfer.setData('Text', dragEl.textContent);
        // 监听元素的dragover dragend 事件
        rootEl.addEventListener('dragover', _onDragOver, false);
        rootEl.addEventListener('dragend', _onDragEnd, false);

        //这里如果不添加setTimeout拖出去的元素也会添加上该类名  
        setTimeout(function () {
            dragEl.classList.add('ghost');
        }, 0)
    }, false);
}

function Drag(EleId) {
    document.getElementById("draggable").draggable();
}

function Drop(EleId) {
    document.getElementById("droppable").droppable({
        hoverClass:"table-hover",
        drop: function (event, ui) {
            $(this).addClass("ui-state-highlight")
                .find("p")
                .html("Dropped!");
        }
    });
}
function Draggable() {
    $("#catalog").accordion();
    $("#catalog li").draggable({
        appendTo: "body",
        helper: "clone"
    });
    $("#cart ol").droppable({
        activeClass: "ui-state-default",
        hoverClass: "ui-state-hover",
        accept: ":not(.ui-sortable-helper)",
        drop: function (event, ui) {
            $(this).find(".placeholder").remove();
            $("<li></li>").text(ui.draggable.text()).appendTo(this);
        }
    }).sortable({
        items: "li:not(.placeholder)",
        sort: function () {
            // 获取由 droppable 与 sortable 交互而加入的条目
            // 使用 connectWithSortable 可以解决这个问题，但不允许您自定义 active/hoverClass 选项
            $(this).removeClass("ui-state-default");
        }
    });
}

function contains(arr, obj) {
    var i = arr.length;
    while (i--) {
        if (arr[i] == obj) {
            return true;
        }
    }
    return false;
}

var poss = new Array();
function OnDrop() {
    if (document.getElementById("placehoder") != null) {
        document.getElementById("placehoder").remove();
    }
    //去重
    //var aa = contains(poss, PosText);
    if (contains(poss, MyPos)) {
        return;
    }
    else {
        poss.push(MyPos);
        var lili = document.createElement("li")
        lili.textContent = MyPos;
        lili.draggable = true;
        lili.sortable = true;
        document.getElementById("products").appendChild(lili);
    }
    
    
}

function AddPosList(pos) {
    var li = document.createElement("li")
    li.textContent = pos;
    li.id = pos + "id";
    li.draggable = true;
    li.sortable = true;
    document.getElementById("products").appendChild(li);
}

function RemovePosList(pos) {
    document.getElementById(pos + "id").remove();
}