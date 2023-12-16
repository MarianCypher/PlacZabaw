using System;

namespace PlacZabaw
{
    public interface IStartable
    {
        // queue parameters
        bool ReadyToStart { get; set; }
        // methods
        public abstract void IsReady();
    }
}