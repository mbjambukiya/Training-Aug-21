// if (typeof (Storage) !== "undefined") {
//     console.log("success");
// } else {
//     console.log("error");
// }

// console.log(Storage);
// console.log(typeof (Storage));
// localStorage.setItem("name", "john");

// var y = localStorage.getItem("name")
// console.log(y);

// localStorage.removeItem("name");

// sessionStorage.setItem("name","steve")
// var x = sessionStorage.getItem("name")
// console.log(x);

// localStorage.setItem("name", "john");
// var x = localStorage.getItem("name")
// localStorage.name = "steave"
// var x = localStorage.getItem("name")
// alert(x)


function counter(demo){
    if(sessionStorage.clickcount){
        sessionStorage.clickcount = parseInt(sessionStorage.clickcount)+1;
    }
    else{
        sessionStorage.clickcount=1;
    }
    demo.innerHTML = sessionStorage.clickcount
}

// var file = "demo.txt"

// var x = fetch(file).then(
//     x=>x.text()
//     ).then(
//         y=>document.getElementById("demo").innerHTML =y
//         )

// console.log(file)

// var x = fetch(file)
// console.log(x)

// var x = fetch(file).then(
//     (success)=>{
//         return success.text()
//     },
//     (error)=>{
//         console.log(error)
//     }
// ).then(
//     (success)=>{
//         console.log(success)
//     },
//     (error)=>{
//         console.log(error)
//     }
// )


// getText("demo.txt");

// async function getText(file) {
//   let x = await fetch(file);
//   let y = await x.text();
//   document.getElementById("demo").innerHTML = y;
// }


// getText("demo.txt");

// async function getText(file) {
//   let myObject = await fetch(file);
//   let myText = await myObject.text();
//   document.getElementById("demo").innerHTML = myText;
// }


const x = document.getElementById("demo");
function getLocation() {
  if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(showPosition);
  } else {
    x.innerHTML = "Geolocation is not supported by this browser.";
  }
}

function showPosition(position) {
  x.innerHTML = "Latitude: " + position.coords.latitude +
  "<br>Longitude: " + position.coords.longitude;
}