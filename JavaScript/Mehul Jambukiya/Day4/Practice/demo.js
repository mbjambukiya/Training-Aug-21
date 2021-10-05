//callback

function add(a,b,callback){
    callback(a+b);
}

add(5,6,(c)=>{
    console.log(c);
})

//asynchronous

setTimeout(myFun, 3000);

function myFun(){
    console.log("hello!")
}

setInterval(myFun, 1000);

function myFun(){
    var d = new Date();
    console.log(d.getHours()+":"+d.getMinutes()+":"+d.getSeconds())
}

//promises

var p = new Promise(function(resolve,reject){
    var x=5;
    if(x==5){
        resolve();
    }
    else{
        reject();
    }
})

p.then(
    function(){
        console.log("Success");
    },
    function(){
        console.log("Error");
    }
)

function getData(data){
    let p = new Promise((resolve,reject)=>{
        let successMessage = {status:'success',message:"done"};
        let errorMessage = {status:'error',message:"failed"};
        if(data==1){
            resolve(successMessage);
        }
        else{
            reject(errorMessage);
        }
    })
    return p;
}

getData(5).then(
    (success)=>{
        console.log(success.message);
    },
    (error)=>{
        console.log(error.message);
    }
)

var res = getData(1)
console.log(res);
console.log(typeof(res));

getData(1).then(
    (success)=>{
        console.log("1st level done.");
        getData(5).then(
            (success)=>{
                console.log("2nd level done.");
            },
            (error)=>{
                console.log("Failed at 2nd level.")
            }
        )
    },
    (error)=>{
        console.log("Failed at 1st level.")
    }
)

//async and await

async function getData(data){
    let p = new Promise((resolve,reject)=>{
        let successMessage = {status:'success',message:"done"};
        let errorMessage = {status:'error',message:"failed"};
        if(data==1){
            resolve(successMessage);
        }
        else{
            reject(errorMessage);
        }
    })

    let res = await p;

    return res;
}

getData(1).then(
    (success)=>{
        console.log(success);
    },
    (error)=>{
        console.log(error);
    }
)


myfun();
function myfun(){
    console.log("hello");
}

var hr = 2;
var minute = 59;
var seconds = 60; 


x = setInterval(() => {
    if(hr>=0){

        seconds-=1;
        if(seconds==0){
            seconds=60;
            minute-=1;
        }
        if(minute==0){
            minute=59;
            hr-=1;
        }
        console.log(hr,minute,seconds)

    }
    else{
        clearInterval(x);
    }

}, 1000);