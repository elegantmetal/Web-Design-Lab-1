using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Design_Lab_1.Models
{
    public class Person
    {
        public string Name;
        public int Age;

        public int Roll;
        public int MMR;
        public string TopHero;

        public Person(string name = "NA", int age = 0, int roll = 0, int mmr = 0, string tophero = "NA")
        {
            Name = name;
            Age = age;
            Roll = roll;
            MMR = mmr;
            TopHero = tophero;
        }
    }
}