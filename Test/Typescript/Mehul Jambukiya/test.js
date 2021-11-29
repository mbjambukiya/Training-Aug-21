// Typescript Practical Test.
var restaurants = [
    { Id: 1, Name: "Star Restaurant", City: "Ahmedabad", Country: "India", OpenTime: "24 x 7", Rating: 3 },
    { Id: 2, Name: "Honest Restaurant", City: "Ahmedabad", Country: "India", OpenTime: "24 x 7", Rating: 5 },
    { Id: 3, Name: "Abc Restaurant", City: "New York", Country: "US", OpenTime: "24 x 7", Rating: 5 }
];
var diningRooms = [
    { Id: 1, Resaurant: 1 },
    { Id: 2, Resaurant: 2 },
    { Id: 3, Resaurant: 2 },
    { Id: 4, Resaurant: 3 },
    { Id: 5, Resaurant: 3 }
];
var diningTables = [
    { Id: 1, DiningRoom: 1, TableCapacity: 6, BookingPricePerHr: 300, IsBooked: false },
    { Id: 2, DiningRoom: 1, TableCapacity: 4, BookingPricePerHr: 200, IsBooked: false },
    { Id: 3, DiningRoom: 2, TableCapacity: 6, BookingPricePerHr: 300, IsBooked: false },
    { Id: 4, DiningRoom: 2, TableCapacity: 4, BookingPricePerHr: 200, IsBooked: false },
    { Id: 5, DiningRoom: 3, TableCapacity: 10, BookingPricePerHr: 500, IsBooked: false },
    { Id: 6, DiningRoom: 3, TableCapacity: 6, BookingPricePerHr: 300, IsBooked: false },
    { Id: 7, DiningRoom: 4, TableCapacity: 4, BookingPricePerHr: 200, IsBooked: false },
    { Id: 8, DiningRoom: 4, TableCapacity: 4, BookingPricePerHr: 200, IsBooked: false },
    { Id: 9, DiningRoom: 5, TableCapacity: 4, BookingPricePerHr: 200, IsBooked: false },
    { Id: 10, DiningRoom: 5, TableCapacity: 4, BookingPricePerHr: 200, IsBooked: false }
];
var bookings;
function BookMyTable(TotalGuests, oneGuestName, DiningTable, BookingDate, BookingHrs) {
    var today = new Date();
    if (BookingDate >= today) {
        console.log("hello");
        today.setMonth(today.getMonth() + 1);
        if (BookingDate <= today) {
            console.log("hello");
            today.setHours(today.getHours() + 6);
            if (BookingDate >= today) {
                console.log("hello");
                var booking = { Id: 1, TotalGuests: TotalGuests, DiningTable: DiningTable, oneGuestName: oneGuestName, BookingDate: BookingDate, BookingHrs: BookingHrs };
                bookings.push(booking);
                return true;
            }
        }
    }
}
function GetRestaurantsList() {
    restaurants.forEach(function (i) {
        console.log("Restautant Id : ".concat(i.Id, ", Restautant Name : ").concat(i.Name, ", Ratings : ").concat(i.Rating, ", City : ").concat(i.City, ", Country : ").concat(i.Country, ", Opens for : ").concat(i.OpenTime));
    });
}
function GetAvailableTables(restaurantId) {
    restaurants.forEach(function (i) {
        if (i.Id == restaurantId) {
            console.log("Restautant Id : ".concat(i.Id, ", Restautant Name : ").concat(i.Name, ", Ratings : ").concat(i.Rating, ", City : ").concat(i.City, ", Country : ").concat(i.Country, ", Opens for : ").concat(i.OpenTime));
        }
    });
    for (var j = 0; j < diningRooms.length; j++) {
        if (diningRooms[j].Resaurant == restaurantId) {
            console.log("Dining room : ".concat(j + 1));
            for (var k = 0; k < diningTables.length; k++) {
                if (diningTables[k].DiningRoom == diningRooms[j].Id && diningTables[k].IsBooked == false) {
                    console.log("Dining Table : ".concat(k + 1, ", Table Capacity : ").concat(diningTables[k].TableCapacity, ", Charges per hour : ").concat(diningTables[k].BookingPricePerHr));
                }
            }
        }
    }
}
console.log("1.Get restaurants list\n2.Get availble dining table details\n3.Book dining table");
var choice = 3;
var BookingToken = 0;
switch (choice) {
    case 1:
        GetRestaurantsList();
        break;
    case 2:
        var restaurantId = 3;
        GetAvailableTables(restaurantId);
        break;
    case 3:
        var TotalGuests = 3;
        var oneGuestName = "Kevin john";
        BookingToken += 1;
        var DiningTable = 7;
        var BookingDate = new Date("2021/12/25 21:00");
        var BookingHrs = 2;
        var bookingStatus = BookMyTable(TotalGuests, oneGuestName, DiningTable, BookingDate, BookingHrs);
        if (bookingStatus == true) {
            console.log("Congratulations!Your table booked successfully!");
            console.log("Booking Details :- ");
            console.log("Token : ".concat(BookingToken, ", Table : ").concat(DiningTable, ", Date : ").concat(BookingDate, ", Time : From ").concat(BookingDate.getHours(), " to ").concat(BookingDate.getHours() + 2));
        }
        else {
            console.log("Something went wrong!Please try again!!");
        }
}
