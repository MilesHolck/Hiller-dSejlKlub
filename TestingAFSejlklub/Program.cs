
using HillerødSejlKlub;
using HillerødSejlKlub.HillerødSejlKlub;
using HillerødSejlKlub.Repositories;

//test af båd
//Boat Wiebke = new Boat("Sejlbåd", "Skonnert", "Wiebke", "20 ft l ft W", 1990);
//Boat Bohlen = new Boat("Motorbåd", "Yacht", "Bohlen", "40 ft l ft W", 2010);

//Console.WriteLine(Wiebke.ToString());
/*
Console.WriteLine("----TEST AF EVENT OG METODER ------");
Console.WriteLine(Wiebke.ToString());

//test af admin/medlem
Member user1 = new Member("carl", 22, 6785678, "Carl@hotmail.com");

Member user2 = new Member("carla", 18, 2345678, "Carla@hotmail.com");

Admin admin1 = new Admin("admin", 30, 87654321, "admin@hotmail.com");

Console.WriteLine(user1.ToString());
Console.WriteLine(user2.ToString());
Console.WriteLine(admin1.ToString());
Console.WriteLine("\n");
//test af damagerapport
//DamageRaport damageR1 = new DamageRaport("damaged paint on the haul", "Camilla Holck");

//Console.WriteLine(damageR1.ToString());
//Console.WriteLine("\n");

//test af event/news samt C.R.U.D
Event event1 = new Event("turnering", "Onsdags Sejlads", new DateTime(2025, 10, 03, 20, 00, 00), false);

News news1 = new News("Vi vandt Igen!", "what it says", event1);

Console.WriteLine(news1.ShowNews());

Console.WriteLine("\n_____________before participants_______________");

Console.WriteLine(event1.ToString());

admin1.AddEventParticipant(event1, user1);
Console.WriteLine("\n_____________ one participant added_______________");

Console.WriteLine(event1.ToString());

event1.Participants.Remove(user1);
Console.WriteLine("\n_____________ one participant Removed_______________");
Console.WriteLine(event1.ToString());

//Console.WriteLine(event1.GetParticipantsInfo());

admin1.UpdateEvent(event1, "turnering", "1. Fredags Sejlads", new DateTime(2029, 10, 04, 03, 00, 00), true);

Console.WriteLine(event1.ToString());
Console.WriteLine("\n");

//Test af booking system 
//Console.WriteLine("__________Booking Test__________");

//Booking booking1 = new Booking (Wiebke, new DateTime(2025, 12, 12, 10, 00, 00), new DateTime(2025, 12, 12, 15, 00, 00), user1, 4, "Hillerød");
//Booking booking2 = new Booking (Bohlen, new DateTime(2025, 12, 21, 10, 00, 00), new DateTime(2025, 12, 21, 15, 00, 00), user2, 2, "Frederikssund");
//Console.WriteLine(booking1.ToString());
//Console.WriteLine(booking2.ToString());

//// Test af Booking Repository
//Console.WriteLine("________BookingRepo Test________");
//BookingRepository repository = new BookingRepository(); //opretter et repository objekt

//booking1.SearchforBoat(DateTime.Now);  
//booking2.SearchforBoat(DateTime.Now);

//booking1.StopBooking(); //stopper booking 1










