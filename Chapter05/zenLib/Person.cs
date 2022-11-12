using System;
using System.Collections.Generic;
using System.Resources;
using static System.Console;

namespace zenLib.Shared
{
    /// <summary>
    /// Class representing a person.
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Konke and bepis.
        /// </summary>
        public string Name;
        public DateTime Dob;
        public string HomePPlanet;
        public WondersOfTheAncientWorld FavoriteWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
}