using System.Collections.Generic;
using gregslistcsharp.Models.cs;

namespace gregslistcsharp.DB.cs
{
    public class FakeDB
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
        public static List<House> Houses { get; set; } = new List<House>();
    }
}