using System;

namespace SportModel
{
    public class Sporter
    {
        private string _naam;
        private Geslacht _geslacht;
        private DateTime _geboortedatum;
        private float _gewicht;
        private int _belastbaarheid;
        
        public void Training()
        {
            _belastbaarheid++;
        }

        public void Wedstrijd()
        {
            _belastbaarheid++;
        }
    }
}
