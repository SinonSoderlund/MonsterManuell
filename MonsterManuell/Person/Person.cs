using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Person
    {
        internal static readonly int LNAME_MIN = 3, LNAME_MAX = 15, FNAME_MIN = 2, FNAME_MAX = 15;
        private int age;
        private double height, weight;
        private string fName, lName;
        public int Age
        {
            get => age;
            set => age = (value > 0 ? value : throw new ArgumentException($"Age must exceed 0, value {value} is not a valid age accoording to program specifications"));
        }
        public double Height
        {
            get => height;
            set => height = value;
        }
        public double Weight
        {
            get => weight;
            set => weight = value;
        }
        public string FName
        {
            get => fName;
            set => fName = StringUtils.StringLenghtValidator(value, FNAME_MIN, FNAME_MAX);
        }
        public string LName
        {
            get => lName;
            set => lName = StringUtils.StringLenghtValidator(value, LNAME_MIN, LNAME_MAX);
        }

        public Person (int age, double height, double weight, string fName, string lName)
        {
            Age = age;
            Height = height;
            Weight = weight;
            FName = fName;
            LName = lName;
        }
        /// <summary>
        /// Prints out the fields of the person in a console- and user-friendly manner
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {FName} {LName}, Age: {Age}, Height: {Height}, Weight: {Weight}";
        }
    }
}
