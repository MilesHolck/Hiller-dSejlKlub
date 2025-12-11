
using HillerødSejlKlub;
using HillerødSejlKlub.HillerødSejlKlub;
using HillerødSejlKlub.Repositories;

//test af båd
Boat boat = new Boat("Sejlbåd", "Skonnert", "Wiebke", "25", "20 ft l ft W", 1990);

Console.WriteLine(boat.ToString());

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
Console.WriteLine("__________Booking Test__________");
Booking booking = new Booking(boat, new DateTime(2025, 10, 10, 15, 00, 00), new DateTime(2025, 10, 10, 18, 00, 00), user1, 3, "Roskilde fjord");

Console.WriteLine(booking.ToString());

Console.WriteLine("__________Booking Test__________");
Booking booking2 = new Booking(boat, new DateTime(2025, 11, 10, 15, 00, 00), new DateTime(2025, 11, 10, 18, 00, 00), user2, 3, "Holbæk fjord");
Console.WriteLine(booking2.ToString());

booking.BoatInTheWater( new DateTime(2025, 11, 10, 15, 00, 00), new DateTime(2025, 11, 10, 18, 00, 00));
Console.WriteLine(booking.Id);
Console.WriteLine(booking2.Id);


