namespace SoundSharp
{
    public class Track
    {
        private int _id;
        private string _name;
        private string _artist;
        private string _albumSource;
        private category _style;
        private time _length;

        public Track()
        {
            
        }
        
        public Track(int id)
        {
            
        }

        public Track(int id, string name)
        {
            
        }

        public Track(int id, string name, string artist)
        {
            
        }

        public string GetLength(int time)
        {
            return (new Time(time)).ToString();
        }

        public int GetLenghtInSeconds(int time)
        {
            return 
        }
    }
}