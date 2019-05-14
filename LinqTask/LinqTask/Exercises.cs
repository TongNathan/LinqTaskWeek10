using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace LinqTask {
    public class PredicateToLambda {
        public List<int> Numbers = new List<int> { 22, 5, 66, 7, 99, 44, 233, 2, 1, 30 };
        public Team Team = new Team("Group 1");

        // convert the following predicate functions into Lambda functions
        public void run() {

            var result = Numbers.Where(FindNumbersLessThan100);
            var people = Team.People.All(FindFirstNamesStartsWithJ);
            var first = Numbers.FirstOrDefault(GreaterThan50);

        }

        public bool FindNumbersLessThan100(int num) {
            return num < 100;
        }

        public bool FindFirstNamesStartsWithJ(Person p) {
            return p.FirstName.StartsWith("J");
        }

        public bool GreaterThan50(int num) {
            return num > 50;
        }
    }

    // Use LINQ method syntax to complete all of the functions in this exercise
    // Run against the unit tests provided
    public class LinqExercises {

        //  return only the strings that have 'pattern' in them
        public IEnumerable<string> FindPattern(IEnumerable<string> inputStrings, string pattern) {
            //Fix the lambda function to check that input has pattern within it.
            return inputStrings.Where(input => input == "Foobar");
        }


        // return inputStrings in alphabetical order
        public IEnumerable<string> OrderAlphabetically(IEnumerable<string> inputStrings) {
            return inputStrings;
        }

        // return all people in a team who are older than age, sorted by Age descending
        public IEnumerable<Person> FindAllGreaterThanAge(Team team, int age) {
            return team.People;
        }

        // return the first Person whose Lastname has num letters
        // return null if none exists
        public Person FindLastnameLength(Team team, int num) {
            return team.People[0];
        }

        // return Last person whose Lastname contains pattern
        // return null if none exists
        public Person FindLastnamePatternLast(Team team, string pattern) {
            return team.People[0];
        }

        // return all numbers between positions of the first occurences of num1 and num2
        // if num1 = 5, num2 = 8 and list = {1, 5, 16, 3, 8, 90, 76}
        // should return {5, 16, 3}
        public IEnumerable<int> NumbersInbetween(IEnumerable<int> list, int num1, int num2) {
            return list;
        }

        // return all people whose birthdays are in month
        public IEnumerable<Person> GetPeopleBirthdayMonth(Team team, int month) {
            return team.People;
        }

        // return the number of people who are older than age
        public int CountAllGreaterThanAge(Team team, int age) {
            return 0;
        }

        // return the age of the person who is the youngest of all people whose Lastname starts with startString
        public int GetYoungestAgeStartsWith(Team team, string startString) {
            return 0;
            //return team.People[0];
        }

        // return the person who is the youngest of all people whose Lastname starts with startString
        public Person GetYoungestStartsWith(Team team, string startString) {
            return team.People[0];
            //return team.People[0];
        }
    }
}
