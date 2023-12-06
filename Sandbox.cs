using System;

namespace PlacZabaw
{
    class Sandbox: IPlayable, IWeightable
    {
        //Properties
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Duration { get; set; }
        public double GetWeight { get; set; }
 
        //Constructor
        public Sandbox(string name, double cost, double duration)
        {
            Name = name;
            Cost = cost;
            Duration = duration;
        }

        //Metody z interfejsow
        public virtual bool Play()
        {
            return $"This {Name} is used right now.";
        }
    }
}