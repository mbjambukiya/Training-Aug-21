function myFun() {
    var tbl = document.getElementById("mytbl");
    var tblcontainer = document.getElementById("tblcontainer")
    var jsondata = [{ id: 1, name: "first" }, { id: 2, name: "second" }]

    for (var i of jsondata) {
        var txt = document.createTextNode(i.id);
        var txt2 = document.createTextNode(i.name);

        var row = document.createElement("tr");
        var col1 = document.createElement("td");
        var col2 = document.createElement("td");

        col1.appendChild(txt);
        col2.appendChild(txt2);

        row.appendChild(col1);
        row.appendChild(col2);

        tbl.appendChild(row);

        tblcontainer.appendChild(tbl);
    }

}