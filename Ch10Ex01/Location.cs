using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ch10Ex01
{
    public class Location
    {
        public Location(double latitude, double longitude)
            => (Latitude, Longitude) = (latitude, longitude);
        public double Latitude { get; }
        public double Longitude { get; }
        public override string ToString() 
            => String.Format($"Latitude: {Latitude}\nLongitude: {Longitude}");
        public void Deconstruct(out double latitude, out double longitude)
            => (latitude, longitude) = (Latitude, Longitude);
    }
}
