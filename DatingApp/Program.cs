using System;
using DatingApp;

Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
string[] samHobbies = { "Listening to audiobooks and podcasts", "Playing rec sports like bowling and kickball", "Writing a speculative fiction novel", "Reading advice columns" };
sam.SetHobbies(samHobbies);

Profile steph = new Profile("Stephanie Reynoso", 22);

Console.WriteLine(sam.ViewProfile());
Console.WriteLine(steph.ViewProfile());
