using System;

namespace gregslistcsharp.Models.cs
{
    public class House
    {
        public House(string name, int levels, int year, int rooms)
        {
            Name = name;
            Levels = levels;
            Year = year;
            Rooms = rooms;
        }

        public string Name { get; set; }
        public int Levels { get; set; }
        public int Year { get; set; }
        public int Rooms { get; set; }
        public string Id { get; private set; } = Guid.NewGuid().ToString();
    }
}