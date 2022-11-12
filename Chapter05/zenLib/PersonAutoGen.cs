using System;
using System.Collections.Generic;
using System.Text;

namespace zenLib.Shared
{
    public partial class Person
    {
        // a property defined using C# 1 - 5 syntax
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePPlanet}";
            }
        }
        // two properties defined using C# 6+ lambda expression body syntax
        public string Greeting => $"{Name} says 'Hello!'";
        public int Age => System.DateTime.Today.Year - Dob.Year;
    }
}
