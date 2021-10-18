

$(function () {


    $("#addcatmodalbody").load("addcategory.html")
    $("#addrecruitmentmodalbody").load("addrecruitment.html")
    $("#addfinalcoursemodalbody").load("addcourse.html")

    $("#studentrmodal .modal-body").load("sregister.html")
    $("#studentlmodal .modal-body").load("slogin.html")
    $("#facultyrmodal .modal-body").load("fregister.html")
    $("#facultylmodal .modal-body").load("flogin.html")
    $("#adminlmodal .modal-body").load("adminlogin.html")
    $("#forgotpasswordmodal .modal-body").load("forgotpassword.html")

    if (sessionStorage.getItem("adminlogin") || sessionStorage.getItem("faclogin") || sessionStorage.getItem("stdlogin")) {
        $("#aloginbtn").hide()
    }
    else {
        $("#alogoutbtn").hide()
    }

    var totalcategories = JSON.parse(localStorage.getItem("coursecategory"))
    $("#totalcategories").text(totalcategories.length)
    var count = 1
    for (i of totalcategories) {

        editcategory = "editcategoryfun('" + i.id + "')"
        removecategory = "removecategoryfun('" + i.id + "')"

        var x = $("<tr></tr>").append(
            $("<td></td>").text(count),
            $("<td></td>").text(i.category),
            $("<td></td>").text(i.interviewer),
            $("<td></td>").append($("<button></button>").text("Edit").attr({ "class": "btn btn-outline-secondary btn-sm", "id": "ecat" + i.category, "onclick": editcategory })),
            $("<td></td>").append($("<button></button>").text("Remove").attr({ "class": "btn btn-outline-secondary btn-sm", "id": "rcat" + i.category, "onclick": removecategory }))
        )

        $("#categorytable>tbody").append(x)
        count += 1;
    }

    var totalrecruitments = JSON.parse(localStorage.getItem("recruitment"))
    $("#totalrecruitments").text(totalrecruitments.length)
    var count = 1
    for (i of totalrecruitments) {

        editrecruitment = "editrecruitmentfun('" + i.id + "')"
        removerecruitment = "removerecruitmentfun('" + i.id + "')"

        var x = $("<tr></tr>").append(
            $("<td></td>").text(count),
            $("<td></td>").text(i.course),
            $("<td></td>").text(i.category),
            $("<td></td>").text(i.syllabus),
            $("<td></td>").text(i.interviewdate),
            $("<td></td>").text(i.lastdatetoapply),
            $("<td></td>").append($("<button></button>").text("Edit").attr({ "class": "btn btn-outline-secondary btn-sm", "id": "erec" + i.course, "onclick": editrecruitment })),
            $("<td></td>").append($("<button></button>").text("Remove").attr({ "class": "btn btn-outline-secondary btn-sm", "id": "rrec" + i.course, "onclick": removerecruitment }))
        )

        $("#recruitmenttable>tbody").append(x)
        count += 1;
    }

    var totalcourses = JSON.parse(localStorage.getItem("course"))
    $("#totalcourses").text(totalcourses.length)
    var count = 1
    for (i of totalcourses) {

        editcourse = "editcoursefun('" + i.id + "')"
        removecourse = "removecoursefun('" + i.id + "')"

        var x = $("<tr></tr>").append(
            $("<td></td>").text(count),
            $("<td></td>").text(i.coursename),
            $("<td></td>").text(i.category),
            $("<td></td>").text(i.duration),
            $("<td></td>").text(i.faculty),
            $("<td></td>").text(i.fees),
            $("<td></td>").text(i.certificate),
            $("<td></td>").text(i.syllabus),
            $("<td></td>").append($("<button></button>").text("Edit").attr({ "class": "btn btn-outline-secondary btn-sm", "id": "ec" + i.course, "onclick": editcourse })),
            $("<td></td>").append($("<button></button>").text("Remove").attr({ "class": "btn btn-outline-secondary btn-sm", "id": "rc" + i.course, "onclick": removecourse }))
        )

        $("#coursetable>tbody").append(x)
        count += 1;
    }

    var registeredstudents = JSON.parse(localStorage.getItem("registeredstudent"))
    $("#registeredstudents").text(registeredstudents.length)

    var registeredfaculties = JSON.parse(localStorage.getItem("facultydata"))
    $("#registeredfaculties").text(registeredfaculties.length)

})

function gotologin(logintype) {
    var modalid = "#" + logintype + "lmodal"
    $(modalid).modal("show")
    $("#demomodal").modal("hide")
}

function alogoutfun() {
    sessionStorage.removeItem("adminlogin")
    sessionStorage.removeItem("stdlogin")
    sessionStorage.removeItem("faclogin")
    $("#alogoutbtn").hide()
    $("#aloginbtn").show()
}

var category = JSON.parse(localStorage.getItem("coursecategory"))
function editcategoryfun(id) {
    newcategory = prompt("Enter new category");
    newinterviewer = prompt("Enter new interviewer");
    if (newcategory && newinterviewer) {

        for (i in category) {
            if (category[i].id == id) {
                category[i].category = newcategory
                category[i].interviewer = newinterviewer
            }
        }
        try {
            localStorage.setItem("coursecategory", JSON.stringify(category))
            alert("Record updated successfully!!")
            window.location.href = ""
        }
        catch (e) {
            alert("Something went wrong,please try again!!")
        }

    }
    else {
        alert("Please fill all fileld!")
    }

}

function removecategoryfun(id) {

    for (i in category) {
        if (category[i].id == id) {
            category.splice(category.indexOf(category[i]), 1)
        }
    }
    try {
        localStorage.setItem("coursecategory", JSON.stringify(category))
        alert("Record updated successfully!!")
        window.location.href = ""
    }
    catch (e) {
        alert("Something went wrong,please try again!!")
    }
}


var recruitment = JSON.parse(localStorage.getItem("recruitment"))
function editrecruitmentfun(id) {
    newcourse = prompt("Enter new course");
    newcategory = prompt("Enter new category");
    newsyllabus = prompt("Enter new syllabus");
    newinterviewdate = prompt("Enter new interviewdate");
    newlastdate = prompt("Enter new lastdate");

    if (newcourse && newcategory && newsyllabus && newinterviewdate && newlastdate) {

        for (i in recruitment) {
            if (recruitment[i].id == id) {
                recruitment[i].course = newcourse
                recruitment[i].category = newcategory
                recruitment[i].syllabus = newsyllabus
                recruitment[i].interviewdate = newinterviewdate
                recruitment[i].lastdatetoapply = newlastdate
            }
        }
        try {
            localStorage.setItem("recruitment", JSON.stringify(recruitment))
            alert("Record updated successfully!!")
            window.location.href = ""
        }
        catch (e) {
            alert("Something went wrong,please try again!!")
        }

    }
    else {
        alert("Please fill all fileld!")
    }

}

function removerecruitmentfun(id) {

    for (i in recruitment) {
        if (recruitment[i].id == id) {
            recruitment.splice(recruitment.indexOf(recruitment[i]), 1)
        }
    }
    try {
        localStorage.setItem("recruitment", JSON.stringify(recruitment))
        alert("Record updated successfully!!")
        window.location.href = ""
    }
    catch (e) {
        alert("Something went wrong,please try again!!")
    }
}


var course = JSON.parse(localStorage.getItem("course"))

function editcoursefun(id) {
    newfees = prompt("Enter new fees");
    newfaculty = prompt("Enter new faculty");
    newsyllabus = prompt("Enter new syllabus");

    if (newfees && newfaculty && newsyllabus) {

        for (i in course) {
            if (course[i].id == id) {
                course[i].fees = newfees
                course[i].faculty = newfaculty
                course[i].syllabus = newsyllabus
            }
        }
        try {
            localStorage.setItem("course", JSON.stringify(course))
            alert("Record updated successfully!!")
            window.location.href = ""
        }
        catch (e) {
            alert("Something went wrong,please try again!!")
        }

    }
    else {
        alert("Please fill all fileld!")
    }

}

function removecoursefun(id) {

    for (i in course) {
        if (course[i].id == id) {
            course.splice(course.indexOf(course[i]), 1)
        }
    }
    try {
        localStorage.setItem("course", JSON.stringify(course))
        alert("Record updated successfully!!")
        window.location.href = ""
    }
    catch (e) {
        alert("Something went wrong,please try again!!")
    }
}
