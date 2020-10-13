
$('.access_li').css('width', $('#box').width() / 3);

var items = document.querySelectorAll('#colla1')

for (var i = 0; i < items.length; i++) {
    items[i].addEventListener("click", function () {
        var className = this.getElementsByClassName('in collapse show')[0];
        if (typeof className == "undefined") {
            this.getElementsByTagName('img')[0].src = '../Content/images/accordion_icn_down.png';
        } else {
            this.getElementsByTagName('img')[0].src = '../Content/images/accordion_icn_open.png';
        }
    })
}

$('.carousel').carousel({
    interval: 4000
})

$(function () {
    $('[data-toggle="tooltip"]').tooltip()
})

var colla2items = document.querySelectorAll('#colla2')

for (var i = 0; i < colla2items.length; i++) {
    colla2items[i].addEventListener("click", function () {
        var className = this.getElementsByClassName('in collapse show')[0];
        if (typeof className == "undefined") {
            this.getElementsByTagName('img')[0].src = '../Content/images/accordion_icn_down_orange.png';
        } else {
            this.getElementsByTagName('img')[0].src = '../Content/images/accordion_icn_open_orange.png';
        }
    })
}

//��hover�ĪG������
$(function () {
    //������ܤ��ռơB���s�\�઺�ܼƭ�
    let setCount = 1; //��ܤ��ռơA�w�]����ܲĤ@��
    let lastSetCount = 3; //���ռƦ��h�ֲաA�ثe��3�աAlastSetCount���̫᪺setCount

    //�������J��/�h�Ф�����ܼƭ�
    let dateClickCount = 0; //�����I�����������(�ثe�]�w2�����@�Ӷg��)
    let InDate_month;
    let InDate_day;
    let OutDate_month;
    let OutDate_day;
    //mouseover���}�����A�A�H�ϧOclick�ƥ�
    var isMouseover = false;
    var isClick = false;

    //��l�ƹw�]9-12������
    $("#iset2m9,#iset2m10,#iset3m11,#iset3m12").hide();

    //������l�A2�����@�Ӷg���A��3���n�^���1�����\��
    $(".day").on({
        "mouseover": function () {
            //�ƹ����ĤG���ᤣ�|��hover�ĪG
            if (dateClickCount < 2) {
                isMouseover = true;
                $(this).css({ "background-color": "#9e8415", "color": "#F5F1ED" });
            }
        },
        "mouseout": function () {
            //�ƹ����ĤG���ᤣ�|��hover�ĪG�A��isMouseover=true�~�|����
            if (dateClickCount < 2 && isMouseover)
                $(this).css({ "background-color": "#F5F1ED", "color": "#3B3B3B" });
        },
        "click": function () {
            dateClickCount++;
            isClick = true;
            isMouseover = false;
            if (dateClickCount >= 3) {
                dateClickCount = 1;
                $("#i-InDate-year,#i-InDate-month,#i-InDate-day,#i-OutDate-year,#i-OutDate-month,#i-OutDate-day").text("");
            }

            if (isClick) {
                switch (dateClickCount) {
                    case 1:
                        //���]����l�˦�
                        $(".day").css({ "background-color": "#F5F1ED", "color": "#3B3B3B" });
                        //dateClickCount=1�A�I��1�U��J�Ф��
                        //console.log("dateClickCount" + dateClickCount);

                        InDate_month = parseInt($(this).parent().parent().children("p").children("span").text());
                        InDate_day = parseInt($(this).text());
                        $("#i-InDate-year").text("2020 �~");
                        $("#i-InDate-month").text(` ${InDate_month} ��`);
                        $("#i-InDate-day").text(` ${InDate_day} ��`);
                        //console.log("InDate_month: " + InDate_month);
                        //console.log("InDate_day: " + InDate_day);
                        //�J���C��ʺA
                        $(this).css({ "background-color": "#9e8415", "color": "#F5F1ED" });
                        break;
                    case 2:
                        //console.log("dateClickCount" + dateClickCount);
                        //dateClickCount=2�A�I��2�U��h�Ф��//��h�Ф��
                        OutDate_month = parseInt($(this).parent().parent().children("p").children("span").text());
                        OutDate_day = parseInt($(this).text());
                        if (InDate_month === OutDate_month && OutDate_day > InDate_day) {
                            $("#i-OutDate-year").text("2020 �~");
                            $("#i-OutDate-month").text(` ${OutDate_month} ��`);
                            $("#i-OutDate-day").text(` ${OutDate_day} ��`);
                            //�h���C��ʺA
                            $(this).css({ "background-color": "#9e8415", "color": "#F5F1ED" });
                        }
                        else if (OutDate_month > InDate_month) {
                            $("#i-OutDate-year").text("2020 �~");
                            $("#i-OutDate-month").text(` ${OutDate_month} ��`);
                            $("#i-OutDate-day").text(` ${OutDate_day} ��`);
                            //�h���C��ʺA
                            $(this).css({ "background-color": "#9e8415", "color": "#F5F1ED" });
                        }
                        else {
                            alert("�Э��s������");
                            dateClickCount = 0;
                            $("#i-InDate-year,#i-InDate-month,#i-InDate-day,#i-OutDate-year,#i-OutDate-month,#i-OutDate-day").text("");
                            //���]����l�˦�
                            $(".day").css({ "background-color": "#F5F1ED", "color": "#3B3B3B" });
                        }
                        //console.log("OutDate_month: " + OutDate_month);
                        //console.log("OutDate_day: " + OutDate_day);
                        break;
                }
            }
        }
    });

    $("#inext").on("click", function () {
        setCount++;
        switch (setCount) {
            case 2:
                //��setCount=2�A�����ܲ�2�դ��(9�B10��)
                //console.log("setCount: " + setCount);
                $("#iset1m7,#iset1m8").hide();
                $("#iset2m9,#iset2m10").show();
                $("#iprevious").css("cursor", "pointer");
                break;
            case 3:
                //��setCount=3�A�����ܲ�3�դ��(11�B12��)
                //console.log("setCount: " + setCount);
                $("#iset2m9,#iset2m10").hide();
                $("#iset3m11,#iset3m12").show();
                $("#inext").css("cursor", "not-allowed");
                break;
            case 4:
                //��setCount=4�A��setCount�ܦ^3�A����setCount���j��3
                setCount = 3;
                //console.log("setCount: " + setCount);
                break;
        }
    })

    $("#iprevious").on("click", function () {
        setCount--;
        switch (setCount) {
            case 0:
                //��setCount=1�A��setCount�ܦ^0�A����setCount���p��1(�ܤ֭n��1�դ��)
                setCount = 1;
                //console.log("setCount: " + setCount);
                break;
            case 1:
                //��setCount=1�A�����ܲ�1�դ��(7�B8��)
                //console.log("setCount: " + setCount);
                $("#iset2m9,#iset2m10").hide();
                $("#iset1m7,#iset1m8").show();
                $("#iprevious").css("cursor", "not-allowed");
                $("#inext").css("cursor", "pointer");
                break;
            case 2:
                //��setCount=2�A�����ܲ�2�դ��(9�B10��)
                //console.log("setCount: " + setCount);
                $("#iset3m11,#iset3m12").hide();
                $("#iset2m9,#iset2m10").show();
                break;
        }
    })
});

function navRWD() {
    var para = document.querySelector(".navClass-RWD");
    para.classList.toggle("navRWDClass");
}

$(function () {
    let navPosition = $("#navbar").offset().top;

    $(window).scroll(function () {
        let scrollTop = $(this).scrollTop();
        if (scrollTop > navPosition)
            $("#navbar").addClass("fixed-nav");
        else
            $("#navbar").removeClass("fixed-nav");
    });
});

//$(function () {
//    var nav = $("#navbar");
//    if (nav.length) {
//        navPosition = nav.offset().top;
//    }

//    $(window).scroll(function () {
//        let scrollTop = $(this).scrollTop();
//        if (scrollTop > navPosition)
//            $("#navbar").addClass("fixed-nav");
//        else
//            $("#navbar").removeClass("fixed-nav");
//    });
//});

$(document).ready(function () {
    $(".tab-content > li").last().hide(); //����.tab-content�U�@�h���̫�@��li

    $(".tabs li").click(function () { //�I��.tabs li�ɡA����H�U�ʧ@
        const type = $(this).data('type'); //.tabs li��data('type')�]��

        if (type === 1) {
            $(".tab-content > li").last().hide();
            $(".tab-content > li").first().show();
            $('.tab-content > li').css('background-color', '#b1d3c5')  //�U�@�h��li�����אּ#b1d3c5
        }

        if (type === 2) {
            $(".tab-content > li").first().hide();
            $(".tab-content > li").last().show();
            $('.tab-content > li').css('background-color', '#e1f1e7')//�U�@�h��li�����אּ#e1f1e7
            $('.tabs > li').last().css('background-color', '#e1f1e7')//.tabs�U�@�h���̫�@��li�אּ#e1f1e7
        }

    })
})

$(document).ready(function () {
    $("#pTwoAct").hide();

    $('#peopleNum').change(function () {  //change�ƥ� 
        var p1 = $(this).children('option:selected').val(); //selected���� 

        if (p1 == 1) {
            $("#pOneAct").show();
            $("#pTwoAct").hide();
        }

        if (p1 == 2) {
            $("#pOneAct").hide();
            $("#pTwoAct").show();

        }
    })
})

$(document).ready(function () {
    $("#petTry").hide();

    $('.petTry').change(function () {  //change�ƥ� 
        var p1 = $(this).children('option:selected').val(); //selected���� 

        if (p1 == 1) {
            $("#petTry").show();
        }

        if (p1 == 2) {
            $("#petTry").hide();

        }
    })
})

$(document).ready(function () {
    //�]�w���D��
    //���������
    var bool = false;
    var offsetX = 0;
    var offsetY = 0;
    $("#ten").mousedown(function () {
        bool = true;
        offsetX = event.offsetX;
        offsetY = event.offsetY;
        //$("#ten").css('cursor', 'move');
    })
        .mouseup(function () {
            bool = false;
        });
    $(document).mousemove(function (e) {
        if (!bool)
            return;
        var x = event.clientX - offsetX;
        var y = event.clientY - offsetY;
        $("#main").css("left", x);
        $("#main").css("top", y);
    })
    //����������
    $("#img").click(function () {
        $("#main").removeClass("show");
        $("#main").addClass("none");
        // $("#open").addClass("show");
    });
    $(".open").click(function () {
        $("#main").removeClass("none");
        $("#main").addClass("show");
    });
});

function openClass(evt, className) {
    var i, x, tablinks;
    x = document.getElementsByClassName("class");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < x.length; i++) {
        tablinks[i].classList.remove("actselectbtncolor");
    }
    document.getElementById(className).style.display = "block";
    evt.currentTarget.classList.add("actselectbtncolor");

}
var mybtn = document.getElementsByClassName("testbtn")[0];
mybtn.click();
//var mybtn = document.getElementsByClassName("testbtn")[0];
//mybtn.click();

function openClass2(evt, className) {
    var i, x, tablinks;
    x = document.getElementsByClassName("class2");
    for (i = 0; i < x.length; i++) {
        x[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablink2");
    for (i = 0; i < x.length; i++) {
        tablinks[i].classList.remove("actselectbtncolor2");
    }
    document.getElementById(className).style.display = "block";
    evt.currentTarget.classList.add("actselectbtncolor2");

}
var mybtn2 = document.getElementsByClassName("testbtn2")[0];
mybtn2.click();


$(function () {
    var date_now = new Date();
    var year = date_now.getFullYear();
    var month = date_now.getMonth() + 1 < 10 ? "0" + (date_now.getMonth() + 1) : (date_now.getMonth() + 1);
    var date = date_now.getDate() < 10 ? "0" + date_now.getDate() : date_now.getDate();
    var month1 = date_now.getMonth() + 2 < 10 ? "0" + (date_now.getMonth() + 1) : (date_now.getMonth() + 1);
    $("#day").attr("min", year + "-" + month + "-" + date);
});

function addActivity() {
    Swal.fire({
        
        icon: 'success',
        title: '�w�[�J�ʪ���',
        showConfirmButton: false,
        timer: 1500
    
    });
}
