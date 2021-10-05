// Function Expression

    function sum(a,b){
        return a+b;
    }

    var x = sum(2,3);
    console.log(x);

    var x = function (a,b){
        return a+b;
    }

    console.log(x);
    var y = x(2,3);
    console.log(y);

    var x = (a,b)=>{
        return a+b;
    }

    console.log(x);
    var y = x(2,3);
    console.log(y);


// Function Constructor

    var sum = new Function("a","b","return a+b");
    console.log(sum)
    var x = sum(2,3)
    console.log(x)

// Self-Invoking function

    (function(){
        console.log("Self-invoked");
    })();

// Function Call

    var person={
        fname:"john",
        lname:"steve",
        fullname:function(){
            return this.fname+" "+this.lname
        }
    }
    console.log(person.fullname());

    var person={
        fullname:function(){
            return this.fname+" "+this.lname
        }
    }

    var person1={
        fname:"john",
        lname:"steve"
    }

    var person2={
        fname:"michel",
        lname:"steve"
    }
    console.log(person.fullname.call(person1));
    console.log(person.fullname.call(person2));


    var person={
        fullname:function(city,country){
            return this.fname+" "+this.lname+" from "+city+","+country;
        }
    }

    var person1={
        fname:"john",
        lname:"steve"
    }

    console.log(person.fullname.call(person1,"Olso","Norway"));


// Function Apply

    var person={
        fullname:function(city,country){
            return this.fname+" "+this.lname+" from "+city+","+country;
        }
    }

    var person1={
        fname:"john",
        lname:"steve"
    }

    console.log(person.fullname.apply(person1,["Olso","Norway"]));

// Function Hoising

    console.log(sqr(5))

    function sqr(a){
        return a*a;
    }

// Global variable & Local Variable

    var x=5;
    function myfun(){
        var y=10;
        return "x:"+x+", y:"+y;
    }

    console.log(myfun())

// Function closure

    var add=(function(){
        var counter=0;
        return function(){
            counter+=1;
            return counter;
        }
    })();

    var x=add();
    console.log(x)
    x=add();
    console.log(x)
    x=add();
    console.log(x)

    function fun1(){
        var x=5;
        function fun2(y){
            x+=5;
            console.log(x,y);
        }
        return fun2;
    }
    var x = 35
    var p = fun1()
    console.log(p);
    p(25);
    p(25);