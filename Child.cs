using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PlacZabaw
{
    //BASE CLASS
    class Child : IPlaygroundEnjoyer, IWeightable
    {
        //Properties
        //IPlayground Enjoyer
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Happiness { get; set; }
        public double Money { get; set; }
        public bool Playing { get; set; }
        public bool Waiting { get; set; }
        public bool Resting { get; set; }
        public bool Accident { get; set; }
        //IWeightable
        public double GetWeight { get; }

        //Constructor
        public Child(string name, int age, string gender, double height, double weight, double happiness, double money, bool playing = false, bool waiting = false, bool resting = false, bool accident = false, double getWeight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            Happiness = happiness;
            Money = money;
            Playing = playing;
            Waiting = waiting;
            Resting = resting;
            Accident = accident;
            GetWeight = getWeight;
        }

        //Metody z interfejsow
        public string MoodCheck()
        {
            /*Skala:
             * Miserable < 1
             * Dissatisfied (1,3>
             * Average (3,8>
             * Contented (8,14>
             * Exalted > 14
             */
            if (Happiness < 1)
            {
                return $"{Name} level of happiness is miserable.";
            }
            else if (Happiness <= 3)
            {
                return $"{Name} is dissatisfied.";
            }
            else if (Happiness <= 8)
            {
                return $"{Name} level of happiness is average.";
            }
            else if (Happiness <= 14)
            {
                return $"{Name} is content. Nice!";
            }
            else
            {
                return $"{Name} is exalted! That's awesome!";
            }
        }
        public string Play()
        {
            return $"{Name} is now playing.";
        }
        public string Wait()
        {
            return $"{Name} is now resting.";
        }
        public string Rest()
        {
            return $"{Name} is now resting.";
        }

        public string CashCheck()
        {
            return $"{Name} still have {Money}PLN.";
        }
        public void AccidentTrigger()
        {
            //Roll if the accident will happen
            Random random = new Random();
            int min = 1;
            int max = 100;
            int randomValue = random.Next(min, max+1);
            if (randomValue < 10)
            {
                Accident = true;
            }
            //Roll which accident happened GettingWeight, LosingMoney, FindingMoney, Depression, CheeringUp
            min = 1;
            max = 5;
            randomValue = random.Next(min, max + 1);
            switch (randomValue)
            {
                case 0: //GettingWeight
                    Weight = Weight*1.1; break;
                case 1: //LosingMoney
                    Money = 0; break;
                case 2: //FindingMoney
                    Money += 20; break;
                case 3: //Depression
                    Happiness = 0 ; break;
                case 4: //CheeringUp
                    Happiness = Happiness*2; break;
            }
        }
    }
}