using System;

namespace PlacZabaw
{
    public interface IEnrolable
    {
        // queue parameters
        string KeenOne {  get; }
        List<string> Queue { get; set; }
        // methods
        public virtual void LineUp()
        {
            Queue.Add(KeenOne);
        }
    }
}