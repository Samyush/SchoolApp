using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure the twitter address starts with @
            get
            {
                return _twitterAddress;

            }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }

        }

        public School()
        {
            Name = "untitled school";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string schoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = schoolPhoneNumber;
        }

        //public float averagethreescores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

    }
}
