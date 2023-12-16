using System;

namespace PlacZabaw
{
    public interface IPlaygroundEnjoyer
    {
        // personal data
        string Name { get; set; }
        int Age { get; set; }
        string Gender { get; set; }
        double Height { get; set; }
        double Weight { get; set; }
        double Happiness { get; set; }
        double Money { get; set; }
        int Queue { get; set; }
        bool Playing { get; set; }
        bool Accident { get; set; }
        bool PlayExtension { get; set; }

        // side effects
        int QueueStatus();
        string Play();
        double Pay();
        bool AccidentTrigger();
        bool PlayExtensionTrigger();
    }
}