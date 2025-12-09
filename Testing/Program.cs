

using HillerødSejlKlub;
using HillerødSejlKlub.Repositories;

Engine eng1 = new Engine();

Boat boat1 = new Boat(eng1, "Something", "another", "boat", "44", "66, 22, 44", 1966);

Boat boat2 = new Boat("Something", "another", "boat", "44", "66, 22, 44", 1966);

BoatRepository boatRepo = new BoatRepository();

boatRepo.AddBoat(boat1);

Boat boatx = boatRepo.GetByNumber("44");

Console.WriteLine(boatx.BoatName);

boat2.BoatName = "Alice"; 

boatRepo.Update(boat2);