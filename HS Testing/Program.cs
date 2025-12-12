using HillerødSejlKlub;
using HillerødSejlKlub.HillerødSejlKlub;
using HillerødSejlKlub.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
// Users 
Admin Adam = new Admin("Adam", 77, 99999999, "AdamsfiktiveEmailVAMONOS");

Member memberName1 = new Member("Loh Draghunhin", 102, 000000000, "LohsEmail");

Member memberName2 = new Member("Purririne", 17, 11111111, "PurririneEmail");

//Events
Event summerSioree = new Event("Summer Sioree", "A fun summer event for all members.", new DateTime(2024, 7, 15), true);

//summerSioree.Participants.Add(new Admin("undescoreName", 23, 88888888, "fiktivEmailUdenSnabela"));

//summerSioree.Participants.Add(new Member("anotherName", 30, 77777777, "anotherEmailUdenSnabela"));

Console.WriteLine(summerSioree.ToString());

Console.WriteLine(summerSioree.GetParticipantsInfo());

Console.WriteLine(summerSioree.GetParticipantsByMemberID(4));

EventRepository eventRepo = new EventRepository();

//Adam.CreateEvent("underscoreEventName", "Super duper nice event", new DateTime(2025, 12, 12), false, eventRepo);

//Adam.AddEventParticipant(summerSioree, memberName1);

//Adam.AddEventParticipant(summerSioree, memberName2);

//Console.WriteLine(eventRepo.ToString());

//Adam.AddEventParticipant(Adam.SomeEvent, memberName1);

Event Julefrokkost = Adam.CreateEvent("Julefrokkost", "Christmas party for all members", new DateTime(2024, 12, 20), true, eventRepo);

Julefrokkost.Participants.Add(memberName1);

Julefrokkost.Participants.Add(memberName2);

Console.WriteLine(Julefrokkost.ToString());

BoatRepository BoatReposiroty = new BoatRepository();   

BoatReposiroty.AddBoat(new Boat("Sailboat", "Model X", "Sea Breeze", "SN123", "30ft", 2015));

BoatReposiroty.AddBoat(new Boat("Motorboat", "Model Y", "Wave Rider", "SN456", "25ft", 2018));

BoatReposiroty.AddBoat(new Boat("Catamaran", "Model Z", "Twin Sail", "SN789", "40ft", 2020));   

Console.WriteLine(BoatReposiroty.GetByNumber("1"));















