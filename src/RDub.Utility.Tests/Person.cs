using System;

namespace RDub.Utility.Tests
{
    public class Person : ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}