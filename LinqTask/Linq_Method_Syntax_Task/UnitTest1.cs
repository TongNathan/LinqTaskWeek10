using System;
using System.Collections.Generic;
using NUnit.Framework;
using LinqTask;
using Models;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        Team team;
        List<string> words;
        List<int> numbers;
        LinqExercises exercises;

        [SetUp]
        public void Setup()
        {
            exercises = new LinqExercises();
            words = new List<string> { "Hello", "World", "Today", "I", "went", "to", "the", "park", "tell", "me", "send" };
            numbers = new List<int> { 6, 78, 77, 2, 88, 33, 88, 90, 21, 111, 767, 8, 9, 22 };


            team = new Team();
            team.TeamName = "Test Team";
            team.People = new List<Person>();

            team.People.Add(new Person("John", "Smith", new DateTime(1950, 2, 5)));
            team.People.Add(new Person("Peter", "Brown", new DateTime(1983, 3, 31)));
            team.People.Add(new Person("Cindy", "White", new DateTime(1890, 6, 30)));
            team.People.Add(new Person("James", "Hallinan", new DateTime(1620, 1, 6)));
            team.People.Add(new Person("Fatima", "Akbar", new DateTime(2001, 12, 9)));
            team.People.Add(new Person("Bill", "Wakanda", new DateTime(2010, 11, 30)));
            team.People.Add(new Person("Vikesh", "Viloo", new DateTime(1996, 2, 13)));
            team.People.Add(new Person("Rone", "Smet", new DateTime(1877, 8, 30)));
            team.People.Add(new Person("Crystal", "Summers", new DateTime(1980, 9, 20)));
            team.People.Add(new Person("Howard", "Duck", new DateTime(2007, 5, 11)));
            team.People.Add(new Person("Pepper", "Salt", new DateTime(2002, 9, 22)));
        }


        [Test]
        public void FindPatternTest()
        {
            List<string> ans1 = new List<string> { "Hello", "tell" };
            List<string> ans2 = new List<string> { "went", "send" };

            Assert.AreEqual(ans1, exercises.FindPattern(words, "el"));
            Assert.AreEqual(ans2, exercises.FindPattern(words, "en"));

        }

        [Test]
        public void OrderAlphabeticallyTest()
        {
            var ordered = new List<string> { "Hello", "I", "me", "park", "send", "tell", "the", "to", "Today", "went", "World" };


            Assert.AreEqual(ordered, exercises.OrderAlphabetically(words));
        }

        [Test]
        public void FindAllGreaterThanAgeTest()
        {
            List<Person> ans1 = new List<Person>();
            ans1.Add(team.People[3]);
            ans1.Add(team.People[7]);
            ans1.Add(team.People[2]);

            Assert.AreEqual(ans1, exercises.FindAllGreaterThanAge(team, 100));
        }

        [Test]
        public void FindLastnameLengthTest()
        {
            Assert.AreEqual(team.People[7], exercises.FindLastnameLength(team, 4));
        }

        [Test]
        public void FindLastnamePatternLastTest()
        {
            Assert.AreEqual(team.People[8], exercises.FindLastnamePatternLast(team, "me"));
        }

        [Test]
        public void NumbersInbetweenTest()
        {
            List<int> ans1 = new List<int> { 2, 88, 33, 88, 90, 21 };
            Assert.AreEqual(ans1, exercises.NumbersInbetween(numbers, 2, 111));
        }

        [Test]
        public void GetPeopleBirthdayMonthTest()
        {
            List<Person> ans1 = new List<Person>();
            ans1.Add(team.People[8]);
            ans1.Add(team.People[10]);

            Assert.AreEqual(ans1, exercises.GetPeopleBirthdayMonth(team, 9));
        }

        [Test]
        public void CountAllGreaterThanAgeTest()
        {
            Assert.AreEqual(3, exercises.CountAllGreaterThanAge(team, 100));
        }

        [Test]
        public void GetYoungestAgeStartsWithTest()
        {
            Assert.AreEqual(team.People[10].GetAge(), exercises.GetYoungestAgeStartsWith(team, "S"));
        }

        [Test]
        public void GetYoungestStartsWithTest()
        {
            Assert.AreEqual(team.People[10], exercises.GetYoungestStartsWith(team, "S"));
        }
    }
}
