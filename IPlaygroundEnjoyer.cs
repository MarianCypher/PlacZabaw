using System;

public interface IPlaygroundEnjoyer
{   
    // personal data
    string Name { get; set; }
    string Age { get; set; }
    string Gender { get; set; }
    string Height { get; set; }
    string Weight { get; set; }
    string Happiness { get; set; }
    string Monay { get; set; }

    // side effects
    bool Queue();
    bool Play();
    bool Pay();
    bool Accident();
    bool PlayExtension();
}