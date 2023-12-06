using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PlacZabaw
{
    class Kido: IPlaygroundEnjoyer, IWeightable
    {
        //Properties
        public double GetWeight { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Happiness { get; set; }
        public double Money { get; set; }
        public int Queue { get; set; }
        public bool Playing { get; set; }
        public bool Accident { get; set; }
        public bool PlayExtension { get; set; }

        //Constructor
        public Kido(double getWeight, string name, int age, string gender, double height, double weight, double happiness, double money, int queue, bool playing = false, bool accident = false, bool playExtension = false)
        {
            GetWeight = getWeight;
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
            Happiness = happiness;
            Money = money;
            Queue = queue;
            Playing = playing;
            Accident = accident;
            PlayExtension = playExtension;
        }

        //Metody z interfejsow
        public int QueueStatus(int position)
        {
            return Queue + position;
        }
        public string Play(string rideName, double price)
        {
            if (rideName == "stop" || rideName == "none")
            {
                Queue = 0;
                Playing = false;
            }
            else
            {
                if (price > Money)
                {
                    Queue = 0;
                    Playing = false;
                    return $"Sorry its out of Your budget.";
                }
                else
                {
                    Playing = true;
                    return $"{Name} is playing on {rideName}";
                    // uzyc tutaj pozostalych metod w metodzie? w koncu zabawa na atrakcji to tez koszt tez ryzyko urazu itp
                }  
            }
        }
        public double Pay(double amount)
        {
            Money -= amount;
            return Money;
        }
        public bool AccidentTrigger()
        {
            Random random = new Random();
            int min = 1;
            int max = 100;
            int randomValue = random.Next(min, max+1);
            if (randomValue < 10)
            {
                Accident = true;
            }
        }
        public bool PlayExtensionTrigger()
        {
            Random random = new Random();
            int min = 1;
            int max = 100;
            int randomValue = random.Next(min, max + 1);
            if (randomValue < 10)
            {
                PlayExtension = true;
            }
        }
    }
}