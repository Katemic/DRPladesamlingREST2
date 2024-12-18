﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DRPladesamlingREST2.Collections
{
    public class Record
    {
        //A music record has attributes like
        //title, artist, duration, publicationYear (dates not allowed: dates = problems when you program)
        //and maybe more attributes …Duration is the of number seconds(a simple int)

        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }


        public Record(string title, string artist, int duration, int publicationYear)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
            
        }

        public Record()
        {
            
        }


        public void ValidateArtist()
        {
            if (Artist == null)
            {
                throw new ArgumentNullException("Artist name cannot be null");
            }
            if (Artist.Length <= 2)
            {
                throw new ArgumentOutOfRangeException("Artist name must be at least 2 characters long");
            }
        }

        public void Validate()
        {
            ValidateArtist();
        }



    }
}
