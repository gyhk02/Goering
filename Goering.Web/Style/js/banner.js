//<![CDATA[
$(function () {
    (function () {
        var curr = 0;
        var length = $("#spanTab a").length;
        $("#jsNav .trigger").each(function (i) {
            $(this).click(function () {
                curr = i;
                $("#banner img").eq(i).fadeIn("slow").siblings("img").hide();
                $(this).siblings(".trigger").removeClass("imgSelected").end().addClass("imgSelected");
                return false;
            });
        });

        var pg = function (flag) {
            //flag:true��ʾǰ���� false��ʾ��
            if (flag) {
                if (curr == 0) {
                    todo = length-1;
                } else {
                    todo = (curr - 1) % length;
                }
            } else {
                todo = (curr + 1) % length;
            }
            $("#jsNav .trigger").eq(todo).click();
        };

        //ǰ��
        $("#prev").click(function () {
            pg(true);
            return false;
        });

        //��
        $("#next").click(function () {
            pg(false);
            return false;
        });

        //�Զ���
        var timer = setInterval(function () {
            todo = (curr + 1) % length;
            $("#jsNav .trigger").eq(todo).click();
        }, 10000);

        //�����ͣ�ڴ�������ʱֹͣ�Զ���
        $("#jsNav a").hover(function () {
            clearInterval(timer);
        },
			function () {
			    timer = setInterval(function () {
			        todo = (curr + 1) % length;
			        $("#jsNav .trigger").eq(todo).click();
			    }, 10000);
			}
		);
    })();
});
//]]>



