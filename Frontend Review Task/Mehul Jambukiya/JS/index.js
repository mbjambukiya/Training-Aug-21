
$(function () {
    var d = new Date()

    var hr = 23 - d.getHours();
    var minute = 59 - d.getMinutes();
    var seconds = 60 - d.getSeconds();

    timerinterval = setInterval(() => {
        if (hr >= 0 && minute >= 0 && seconds >=0) {

            seconds -= 1;
            if (seconds == 0) {
                seconds = 60;
                minute -= 1;
            }
            if (minute == 0) {
                minute = 59;
                hr -= 1;
            }
            $("#timer").text(hr + ":" + minute + ":" + seconds)
        }
        else {
            clearInterval(timerinterval);
            $("#offeralert").hide()
        }

    }, 1000);

    $("#studentrmodal .modal-body").load("sregister.html")
    $("#studentlmodal .modal-body").load("slogin.html")
    $("#facultyrmodal .modal-body").load("fregister.html")
    $("#facultylmodal .modal-body").load("flogin.html")
    $("#adminlmodal .modal-body").load("adminlogin.html")
    $("#forgotpasswordmodal .modal-body").load("forgotpassword.html")

    var course = JSON.parse(localStorage.getItem("course"))
    var arr = new Array()
    for (i of course) {
        if (!arr.includes(i.category)) {
            arr.push(i.category)
        }
    }
    var flag;
    var myrow = $("<div></div>").attr("class", "row g-3 my-3 text-center")

    for (i of arr) {
        flag = 0

        $("<a></a>").text(i).attr("href", "courses.html#" + i).appendTo($("<li></li>")).appendTo($("#categoryul"))

        $("<h3></h3>").text(i).attr("class", "my-3 bg-light p-3").appendTo($("#maindiv"))

        var row = $("<div></div>").attr("class", "row g-3 my-3 text-center")

        for (j of course) {
            var col = $("<div></div>").attr("class", "col-lg-3 col-md-6 col-sm-12")
            var mycol = $("<div></div>").attr("class", "col-lg-3 col-md-6 col-sm-12 mt-0")

            if (j.category == i) {


                var x = $("<div></div>").attr("class", "card").append(
                    $("<div></div>").attr("class", "card-body").append(
                        $("<h5></h5>").text(j.coursename).attr("class", "mb-3"),
                        $("<p></p>").text("Faculty : " + j.faculty),
                        $("<p></p>").text("Course Duration : " + j.duration + " hrs"),
                        $("<p></p>").text("Course Validity : " + j.validity + " months"),
                        $("<p></p>").append($("<a></a>").text("View Syllabus").attr("href", j.syllabus)),
                        $("<p></p>").text("Certificate available? : " + j.certificate),
                        $("<p></p>").text("Course Fees : " + j.fees),
                        $("<a></a>").text("Enroll").attr({ "class": "btn btn-primary me-2", "href": "enrollpage.html?senddata" + "=" + JSON.stringify(j), "value": j.coursename, "id": "en" + j.coursename })
                    )
                )

                $("#maindiv").append(row.append(col.append(x)))
                if (flag == 0) {
                    var y = $("<div></div>").attr("class", "card").append(
                        $("<div></div>").attr("class", "card-body").append(
                            $("<h5></h5>").text(j.coursename).attr("class", "mb-3"),
                            $("<p></p>").text("Faculty : " + j.faculty),
                            $("<p></p>").text("Course Duration : " + j.duration + " hrs"),
                            $("<p></p>").text("Course Validity : " + j.validity + " months"),
                            $("<p></p>").append($("<a></a>").text("View Syllabus").attr("href", j.syllabus)),
                            $("<p></p>").text("Certificate available? : " + j.certificate),
                            $("<p></p>").text("Course Fees : " + j.fees),
                            $("<a></a>").text("Enroll").attr({ "class": "btn btn-primary me-2", "href": "enrollpage.html?senddata" + "=" + JSON.stringify(j), "value": j.coursename, "id": "en" + j.coursename })
                        )
                    )
                    $("#popularcourses").append(myrow.append(mycol.append(y)))
                }
                flag = 1
            }
        }
    }

})