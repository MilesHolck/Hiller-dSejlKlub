
using HillerødSejlKlub;
using HillerødSejlKlub.HillerødSejlKlub;
using HillerødSejlKlub.Repositories;

/*
Console.WriteLine("----TEST AF EVENT OG METODER ------");

Event event1 = new Event("Middag", "Mad", new DateTime(2025, 12, 13, 14, 30, 00), false);

Console.WriteLine(event1.ToString());


Member member1 = new Member("Sally", 30, 12334232, "sally.com");

Member member2 = new Member("Bob", 12, 377895639, "email");


Admin admin1 = new Admin("Bobby", 12, 22222222, "yahoo@gmail.com");

Admin admin2 = new Admin("Johanne", 22, 47433285, "noget@noget.dk");

admin1.AddEventParticipant(event1, member1);
admin1.AddEventParticipant(event1, member2);

Console.WriteLine(event1.ToString());

Console.WriteLine(event1.GetParticipantsInfo());

Console.WriteLine(event1.GetParticipantsByMemberID(3));

Console.WriteLine(member2.ToString());

Console.WriteLine("--------TEST AF NEWS--------");

News news1 = new News("Broen skal op", "Vi hiver den bro op");

Console.WriteLine(news1.ShowNews());

News news2 = new News("Vi holder sommerfest", "Og andre spændende arrengementer hele sæsonen!", event1);

Console.WriteLine(news2.ShowNews());
*/


/*

//TEST AF BOAT OG METODER. 

Boat boat1 = new Boat("En type af båd", "Også en model", "Going Merry", "55", "Nogle mål", 1922);

Boat boat2 = new Boat("Vi skal bruge en string her", "Modellos", "NOGET MED STORT", "42", "mål, mål, mål", 2005);

Boat boat3 = new Boat("Sejlbåd", "Flot model", "noget laaaaaaaaaaaaaaaangt", "12", "flere mål og flere mål", 2020);

Member member1 = new Member("Sally", 30, 12334232, "sally.com");

Member member2 = new Member("Bob", 12, 377895639, "email"); 

//boat1.AddDamage("hul i masten", member1);

Console.WriteLine(boat1.Skadesrapport());

string damRepo2 = boat1.AddDamage("Rids i lakken", member1);

Console.WriteLine(boat1.Skadesrapport());

Console.WriteLine(boat1); 

Console.WriteLine("-----------------TEST AF BOOKING-------------------");

Booking booking1 = new Booking(boat1, new DateTime(2025, 12, 12, 12, 00, 00), new DateTime(2025, 12, 12, 14, 00, 00), member1, 1, "Møn");

Booking booking2 = new Booking(boat1, new DateTime(2025, 12, 12, 12, 00, 00), new DateTime(2025, 12, 12, 14, 00, 00), member2, 1, "Ærø");

booking1.SearchforBoat(11);

booking1.StopBooking();

booking1.SearchforBoat(15);

Console.WriteLine(booking2.ToString());

Console.WriteLine("-------------TEST AF DAMAGE REPORT-------------");

DamageReport damrepo1 = new DamageReport("Et eller andet", member2);

Console.WriteLine(boat1.Skadesrapport());

Console.WriteLine(damRepo2.ToString());

Engine eng1 = new Engine("v12", "BOAT");

Console.WriteLine(eng1.ToString());

Engine eng2 = new Engine();

Console.WriteLine(eng2.ToString()); 
*/



//TEST AF ADMIN OG METODER.
/*

Admin admin1 = new Admin("Bobby", 12, 22222222, "yahoo@gmail.com");

Admin admin2 = new Admin("Sally", 22, 47433285, "noget@noget.dk");

EventRepository eventRepo = new EventRepository();

Event event1 = admin1.CreateEvent("Kapsejlads", "Noget med kap og sejlads", new DateTime(2025, 12, 12, 20, 30, 00), true, eventRepo);

Console.WriteLine(event1);

admin1.AddEventParticipant(event1, admin2);

Console.WriteLine(event1);

admin1.UpdateEvent(event1, "Parsejlads", "Noget med par og sejlads", new DateTime(2025, 12, 13, 19, 00, 00), false);

Console.WriteLine(event1);

admin1.DeleteEvent(event1, eventRepo);

Console.WriteLine(eventRepo);

Console.WriteLine(admin1.ToString());


Console.WriteLine(admin1.ToString());

MemberRepository memberRepo = new MemberRepository();

*/



//TEST AF EVENTREPOSITORY

/*

Event event1 = new Event("turnering", "Onsdags Sejlads", new DateTime(2025, 10, 03, 20, 00, 00), false);

Event event2 = new Event("Kapsejlads", "noget med kap og sejlads", new DateTime(2026, 01, 03, 12, 00, 00), true);

Event event3 = new Event("Parsejlads", "Par som sejler", new DateTime(2025, 10, 30, 20, 30, 00), false);

EventRepository eventRepo = new EventRepository();

eventRepo.AddEvent(event1);

eventRepo.AddEvent(event2);
Console.WriteLine("------PRINTALL------"); 
eventRepo.PrintAll();
Console.WriteLine("-----DELETEEVENT------"); 
eventRepo.DeleteEvent(event1);
Console.WriteLine("-----PRINTALL-----");
eventRepo.PrintAll();
Console.WriteLine("------ADDEVENT------"); 
eventRepo.AddEvent(event1);
Console.WriteLine("-----PRINTALL-----");
eventRepo.PrintAll();
Console.WriteLine("------DELETE----- (event not on list)");
eventRepo.DeleteEvent(event3);

Console.WriteLine("-----UPDATE------");
eventRepo.UpdateEvent(event2, "Bådsejlads", "Sejlads i både", new DateTime(2025, 10, 02, 13, 00, 00), false);

string findEvent = eventRepo.GetByName("Bådsejlads");

Console.WriteLine("----GETBYNAME-----"); 
Console.WriteLine(findEvent);

Console.WriteLine("-------COUNT-----");

Console.WriteLine(eventRepo.Count());

eventRepo.AddEvent(event3);

Console.WriteLine("-----TOSTRING------"); 

Console.WriteLine(eventRepo.ToString());

*/



//TEST AF BOAT REPO


Boat boat1 = new Boat("Sejlbåd", "Skonnert", "Wiebke", 09, "20 ft l ft W", 1990);

Boat boat2 = new Boat("EnBådType", "EnModel", "EtNavn", 40, "Nogle mål", 1999);

Boat boat3 = new Boat("Endnu en bådtype", "endnu en model", "endnu et navn", 10, "flere mål", 1855);

Member Ida = new Member("Ida", 33, 22222222, "hallo@ida.dk");

BoatRepository boatRepo = new BoatRepository();

boatRepo.AddBoat(boat1);

boatRepo.AddBoat(boat2);

boatRepo.PrintAll();

boatRepo.Update(boat2, "Sejlbåd", "Skonnert", "Sif", 42, "30 ft, 20 ft, 10 ft", 1999);

boatRepo.DeleteBoat(boat1);

boatRepo.PrintAll();
boatRepo.AddBoat(boat1);
boatRepo.AddBoat(boat3);

Console.WriteLine("--------TEST AF FIND BY NUMBER------");

Console.WriteLine(boatRepo.GetByNumber(777)); 







/*

//TEST AF ADMIN/MEDLEM

User member1 = new Member("Bob", 22, 6785678, "Carl@hotmail.com");

User member2 = new Member("Sloan", 18, 2345678, "Carla@hotmail.com");

User member3 = new Member("Sally", 30, 87654321, "admin@hotmail.com");

MemberRepository memberRepo = new MemberRepository();

Console.WriteLine("-----ADDING MEMBERS-----"); 

memberRepo.Add(member1);

memberRepo.Add(member2);

Console.WriteLine("--------PRINTALL------");

memberRepo.PrintAll();

Console.WriteLine("-------UPDATE---------");

memberRepo.Update(member2, "Bread", 33, 12341234, "yahoo@google.com");

Console.WriteLine("---------DELETE---------");

memberRepo.Delete(member1);
memberRepo.Delete(member3);

Console.WriteLine("------PRINTALL-------");
memberRepo.PrintAll();

Console.WriteLine("ADD MORE MEMBERS");
memberRepo.Add(member1);
memberRepo.Add(member3);

Console.WriteLine("---PRINTALL----"); 
memberRepo.PrintAll();

Console.WriteLine("----GET BY NAME ----");
Console.WriteLine(memberRepo.GetByName("Sally"));

Console.WriteLine(memberRepo.GetByName("Troels"));

Console.WriteLine("-----COUNT-------"); 
Console.WriteLine(memberRepo.Count());

Console.WriteLine("-----GET MEMBER BY ID------");
Console.WriteLine(memberRepo.GetMemberById(1));
Console.WriteLine(memberRepo.GetMemberById(4));

Console.WriteLine("-------- REPO TO STRING ---------"); 
Console.WriteLine(memberRepo.ToString()); 
*/


/*
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
*/








