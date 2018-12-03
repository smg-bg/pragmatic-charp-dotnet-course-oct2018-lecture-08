using System;

namespace ClassesAndObjects
{
    class Cat
    {
        private string _name = "unnamed";

        public string Name
        {
            get => _name;
            private set { _name = value; }
        }

        public string Owner { get; }


        public Cat(string name)
        {
            _name = name;
            Owner = "Martin";
        }

        public void SayUsualPhrase(string message = "meow")
        {
            Console.WriteLine(Name + " says " + message);
        }

        public void SayUsualPhrase(string message, int numberOfTimes)
        {
            for (int index = 0; index < numberOfTimes; index++)
                SayUsualPhrase(message);
        }


        public bool TryParse(string stringToParse, out int parsedValue)
        {
            // some dummy logic to parse the string 
            if (string.IsNullOrWhiteSpace(stringToParse))
            {
                parsedValue = 7;

                return true;
            }

            parsedValue = default(int);
            return false;
        }

        public class RiskRatingValue
        {
            public double RiskRatingAsNumber { get; set; }
        }

        public RiskRatingValue CalculateRiskRating(double a, double b, double c)
        {
            RiskRatingValue result = new RiskRatingValue();
            result.RiskRatingAsNumber = a * b + Math.Pow(c, 2);

            return result;
        }
    }

}
