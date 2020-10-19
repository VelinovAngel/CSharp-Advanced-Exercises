﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {

        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo([AllowNull] Person other)
        {
            //1 -> this is bigger
            //0 -> They are equal
            //-1 -> other is bigger

            //I assum that this is bigger
            int result = 1;

            if (other != null)
            {
                //I start comparing
                result = this.name.CompareTo(other.name);

                if (result == 0)
                {
                    //If my name come first -> 1
                    //They are equal -> 0
                    //Other is first -> -1

                    result = this.age.CompareTo(other.age);

                    //I start comparing
                    if (result == 0)
                    {
                        result = this.town.CompareTo(other.town);
                    }

                }
            }

            return result;
        }
    }
}
