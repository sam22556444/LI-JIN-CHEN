$('.access_li').css('width', $('#box').width() / 3);

var items = document.querySelectorAll('#colla1')

for (var i = 0; i < items.length; i++) {
    items[i].addEventListener("click", function () {
        var className = this.getElementsByClassName('in collapse show')[0];
        if (typeof className == "undefined") {
            this.getElementsByTagName('img')[0].src = '/images/accordion_icn_down.png';
        } else {
            this.getElementsByTagName('img')[0].src = '/images/accordion_icn_open.png';
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
            this.getElementsByTagName('img')[0].src = '/images/accordion_icn_down_orange.png';
        } else {
            this.getElementsByTagName('img')[0].src = '/images/accordion_icn_open_orange.png';
        }
    })
}

//��hover�ĪG������
$(function () {
    //������ܤ��ռơB���s�\�઺�ܼƭ�
    let setCount = 1; //��ܤ��ռơA�w�]����ܲĤ@��
    let lastSetCount = 2; //���ռƦ��h�ֲաA�ثe��2�աAlastSetCount���̫᪺setCount

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
    $("#iset3m11,#iset3m12").hide();

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
                //��setCount=2�A�����ܲ�2�դ��(11�B12��)
                //console.log("setCount: " + setCount);
                $("#iset2m9,#iset2m10").hide();
                $("#iset3m11,#iset3m12").show();
                $("#iprevious").css("cursor", "pointer");
                $("#inext").css("cursor", "not-allowed");
                break;
            case 3:
                //��setCount=3�A��setCount�ܦ^2�A����setCount���j��2
                setCount = 2;
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
                //��setCount=1�A�����ܲ�1�դ��(9�B10��)
                //console.log("setCount: " + setCount);
                $("#iset3m11,#iset3m12").hide();
                $("#iset2m9,#iset2m10").show();              
                $("#iprevious").css("cursor", "not-allowed");
                $("#inext").css("cursor", "pointer");
                break;
            case 2:
                //��setCount=2�A�����ܲ�2�դ��(11�B12��)
                console.log("setCount: " + setCount);
                $("#iset3m9,#iset3m10").hide();
                $("#iset2m11,#iset2m12").show();
                $("#iprevious").css("cursor", "pointer");
                $("#inext").css("cursor", "not-allowed");
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
        var navIcon = document.querySelectorAll('#navIcon');
        let scrollTop = $(this).scrollTop();
        if (scrollTop > navPosition) {
            $("#navbar").addClass("fixed-nav");
            navIcon[0].addEventListener("mouseover", function () {
                this.getElementsByTagName('img')[0].src = '/images/logoHoverWhite.png';
            });
            navIcon[0].addEventListener("mouseout", function () {
                this.getElementsByTagName('img')[0].src = '/images/logo.png';
            });
        }
        else {
            $("#navbar").removeClass("fixed-nav");
            navIcon[0].addEventListener("mouseover", function () {
                this.getElementsByTagName('img')[0].src = '/images/logoHover.png';
            });

            navIcon[0].addEventListener("mouseout", function () {
                this.getElementsByTagName('img')[0].src = '/images/logo.png';
            });
        }
    });
});

$(document).ready(function () {
    var navIcon = document.querySelectorAll('#navIcon');
    navIcon[0].addEventListener("mouseover", function () {
        this.getElementsByTagName('img')[0].src = '/images/logoHover.png';
    });

    navIcon[0].addEventListener("mouseout", function () {
        this.getElementsByTagName('img')[0].src = '/images/logo.png';
    });
});



$(document).ready(function () {
    $(".tab-content > li").last().hide(); //����.tab-content�U�@�h���̫�@��li

    $(".tabs li").click(function () { //�I��.tabs li�ɡA����H�U�ʧ@
        const type = $(this).data('type'); //.tabs li��data('type')�]��

        if (type === 1) {
            $(".tab-content > li").last().hide();
            $(".tab-content > li").first().show();
            $('.tab-content > li').css('background-color', '#b1d3c5')  //�U�@�h��li�����אּ#b1d3c5
            $('.tabs > li').first().css('background-color', '#b1d3c5')//.tabs�U�@�h���̫�@��li�אּ#e1f1e7

            $('.tabs > li').last().css('background-color', '#e1f1e7')//.tabs�U�@�h���̫�@��li�אּ#e1f1e7

        }

        if (type === 2) {
            $(".tab-content > li").first().hide();
            $(".tab-content > li").last().show();

            $('.tab-content > li').css('background-color', '#b1d3c5')//�U�@�h��li�����אּ#e1f1e7
            $('.tabs > li').first().css('background-color', '#e1f1e7')//.tabs�U�@�h���̫�@��li�אּ#e1f1e7

            $('.tabs > li').last().css('background-color', '#b1d3c5')//.tabs�U�@�h���̫�@��li�אּ#e1f1e7
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

//$("button.placeorder").click(function (e) {
//    e.preventDefault();

//    var $this = $(this);

//    //var url = "/cart/PlaceOrder";
//    var url = "/Booking/BookingPayment";

//    $.post(url);

//    $(".ajaxbg").show();

//    $.post(url, {}, function (data) {
//        $(".ajaxbg span").text("Thank you. You will now be redirected to paypal.");
//        setTimeout(function () {
//            $('form input[name="submit"]').click();
//        }, 2000);
//    });
//});

$("button.placeorderforstripe").click(function () {
    $(".stripe-button-el").click();
});

$("#resetCode").click(function () {

    $.ajax({
        url: "/Members/CreateCodeIn",
        type: "Get",
        success: function (data) {
            var s1 = data.substr(0, 1) + ".png";
            var s2 = data.substr(1, 1) + ".png";
            var s3 = data.substr(2, 1) + ".png";
            var s4 = data.substr(3, 1) + ".png";
            $("#codeIn").html(
                `
                <img src="/images/${s1}" width="30px" height="38px" />
                <img src="/images/${s2}" width="30px" height="38px" />
                <img src="/images/${s3}" width="30px" height="38px" />
                <img src="/images/${s4}" width="30px" height="38px" />
                `);
        }
    });
});

$(document).ready(function () {
    $("#Pet").hide();

    $('.trypet').change(function () {  //change�ƥ�
        var p1 = $(this).children('option:selected').val(); //selected����

        if (p1 == 1) {
            $("#Pet").show();
        }

        if (p1 == 2) {
            $("#Pet").hide();

        }
    })
})

$("#calendarButton").click(function () {
    var InYear = document.getElementById("i-InDate-year").innerText;
    var InMonth = document.getElementById("i-InDate-month").innerText;
    var InDate = document.getElementById("i-InDate-day").innerText;
    var OutYear = document.getElementById("i-OutDate-year").innerText;
    var OutMonth = document.getElementById("i-OutDate-month").innerText;
    var OutDate = document.getElementById("i-OutDate-day").innerText;
    console.log("123");
    $.ajax({
        url: "/Booking/DateIntoSession",
        type: "Post",
        data: { "InYear": InYear, "InMonth": InMonth, "InDate": InDate, "OutYear": OutYear, "OutMonth": OutMonth, "OutDate": OutDate },
        success: function (data) {
            console.log("123");
            window.location.href = data;
           
        }
    });

})

$("#refreshPet").click(function () {
    $.ajax({
        url: "/Booking/RefreshPet",
        type: "Get",
        success: function (data) {
            $("#petBlock").html("");
            $.each(data, function (index, data) {
                $("#petBlock").append(
                    `
                    <div class="card ml-4 mr-3" style="min-width:310px;max-width:310px; margin-bottom:20px">
                        <img src="${data.fTryPetPhoto}" class="card-img-top">
                        <div class="card-body">
                            <h5 class="card-title tac ls025 fz15 mt2 mb3 mb0">${data.fTryPetName}</h5>
                            <p class="card-text">
                                <ul class="list-unstyled fz1 lh25 ml15">
                                    <li>�����G${data.fTryPetVar}�@<span class="ml10">�ʧO�G${data.fTryPetSex}</span></li>
                                    <li>�~�֡G ${data.fTryPetAge} ��<span class="ml10">�魫�G${data.fTryPetWei} ����</span></li>
                                    <li>�w���|�G${data.fTryPetFix}<span class="ml10">�өʡG${data.fTryPetNature}</span></li>
                                </ul>
                            </p>
                            <div class="form-ac-check br25 ac-check" style="margin-top:-15px;margin-bottom:-15px">
                                <label class="form-check-label ac-lab mr3 mt2">
                                    <input type="radio" name="petradio" class="form-check-input-act ac-input" value="${data.fTryPetId}" id="pet-${data.fTryPetId}">
                                </label>
                                <label class="fz125" for="pet-${data.fTryPetId}">
                                    �վi ${data.fTryPetName}
                                </label>
                            </div>
                        </div>
                    </div>
                    `
                )
            })
        }
    })
})

$("#BookingNextStage1").click(function () {
    $("#BookingNextStage2").click();
})


//$("#paypal-button").click(function () {
//    $.ajax({
//        url: "/Booking/PayPalPayment",
//        type: "Get",
//        success: function (data) {
//            console.log(data);
//            document.location.href = data;

//        }
//    })  
//})

function formActivity() {
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            cancelButton: 'btn btn-danger mr5',
            confirmButton: 'btn btn-success ml5'
        },
        buttonsStyling: false
    });

    swalWithBootstrapButtons.fire({
        title: '�O�_�e�X���ʪ��',
        text: "�Ш̷ӳW�w��g,���ųW�w�����h��!",
        icon: 'warning',
        showCancelButton: true,
        cancelButtonText: '����!',
        confirmButtonText: '�T�w�e�X!',
        reverseButtons: true
    }).then((result) => {
        if (result.value) {
            swalWithBootstrapButtons.fire({
                title: '�w�e�X���',
                text: "���f��7��,�Цb�ӽФ����ʬd�ݶi��",
                icon: 'success',
                reverseButtons: true,
                confirmButtonText: '�^�쬡�ʭ���'
            }).then((result) => {
                $("#actlogin").click();
            });
        }
    });

}
//�ӽЬ��ʪ��z��
function checknamevalue(id) {
    var namevalue = document.getElementById("formtext" + id).value;
    var checkvalue = document.getElementById("checkvalue" + id);
    var reg = /^[\u4E00-\u9FA5]+$/;
    console.log(namevalue);
    if (namevalue === "") {
        checkvalue.innerHTML = "�п�J����";
        checkvalue.style.color = "#888888";
    }
    else if (namevalue !== "" && namevalue.length >= 2 && reg.test(namevalue)) {


        checkvalue.innerHTML = "�榡���T";
        checkvalue.style.color = "green";
    }
    else {

        checkvalue.innerHTML = "�榡���ŦX:�п�J����";
        checkvalue.style.color = "red";
    }
}
function checkpwdvalue(id) {
    var pwdvalue = document.getElementById("formtext" + id).value;
    var checkpwdvalue = document.getElementById("checkvalue" + id);
    var reg = /\d/;
    if (pwdvalue === "") {
        checkpwdvalue.innerHTML = "�п�J�Ʀr";
        checkpwdvalue.style.color = "#888888";
    }
    else if (pwdvalue !== "" && reg.test(pwdvalue)) {
        checkpwdvalue.innerHTML = "�榡���T";
        checkpwdvalue.style.color = "green";
    }
    else {
        checkpwdvalue.innerHTML = "�榡���ŦX:�п�J�Ʀr";
        checkpwdvalue.style.color = "red";
    }
}
